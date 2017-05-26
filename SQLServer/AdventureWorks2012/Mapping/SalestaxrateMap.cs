using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class SalestaxrateMap : ClassMapping<Salestaxrate> {
        
        public SalestaxrateMap() {
			Schema("Sales");
			Lazy(true);
			Id(x => x.Salestaxrateid, map => map.Generator(Generators.Identity));
			Property(x => x.Taxtype, map => { map.NotNullable(true); map.Precision(3); });
			Property(x => x.Taxrate, map => 
			{
				map.NotNullable(true);
				map.Precision(10);
				map.Scale(4);
			});
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Stateprovince, map => { map.Column("StateProvinceID"); map.Cascade(Cascade.None); });

        }
    }
}
