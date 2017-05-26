using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class CultureMap : ClassMapping<Culture> {
        
        public CultureMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Cultureid, map => map.Generator(Generators.Assigned));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Productmodelproductdescriptionculture, colmap =>  { colmap.Key(x => x.Column("CultureID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
