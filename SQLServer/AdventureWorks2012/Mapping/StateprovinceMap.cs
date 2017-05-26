using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class StateprovinceMap : ClassMapping<Stateprovince> {
        
        public StateprovinceMap() {
			Schema("Person");
			Lazy(true);
			Id(x => x.Stateprovinceid, map => map.Generator(Generators.Identity));
			Property(x => x.Stateprovincecode, map => { map.NotNullable(true); map.Length(3); });
			Property(x => x.Isonlystateprovinceflag, map => map.NotNullable(true));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Countryregion, map => { map.Column("CountryRegionCode"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Salesterritory, map => 
			{
				map.Column("TerritoryID");
				map.PropertyRef("Territoryid");
				map.Cascade(Cascade.None);
			});

			Bag(x => x.Address, colmap =>  { colmap.Key(x => x.Column("StateProvinceID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
