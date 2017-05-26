using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class CountryregionMap : ClassMapping<Countryregion> {
        
        public CountryregionMap() {
			Schema("Person");
			Lazy(true);
			Id(x => x.Countryregioncode, map => map.Generator(Generators.Assigned));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Stateprovince, colmap =>  { colmap.Key(x => x.Column("CountryRegionCode")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
