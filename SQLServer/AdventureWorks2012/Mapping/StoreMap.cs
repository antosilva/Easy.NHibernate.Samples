using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class StoreMap : ClassMapping<Store> {
        
        public StoreMap() {
			Schema("Sales");
			Lazy(true);
			Id(x => x.Businessentityid, map => map.Generator(Generators.Assigned));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Demographics);
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Businessentity, map => { map.Column("BusinessEntityID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Salesperson, map => 
			{
				map.Column("SalesPersonID");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			Bag(x => x.Customer, colmap =>  { colmap.Key(x => x.Column("StoreID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
