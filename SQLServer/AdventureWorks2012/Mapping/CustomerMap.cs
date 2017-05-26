using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class CustomerMap : ClassMapping<Customer> {
        
        public CustomerMap() {
			Schema("Sales");
			Lazy(true);
			Id(x => x.Customerid, map => map.Generator(Generators.Identity));
			Property(x => x.Accountnumber, map => { map.NotNullable(true); map.Length(10); });
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Person, map => 
			{
				map.Column("PersonID");
				map.PropertyRef("Businessentityid");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Store, map => 
			{
				map.Column("StoreID");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Salesterritory, map => 
			{
				map.Column("TerritoryID");
				map.PropertyRef("Territoryid");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			Bag(x => x.Salesorderheader, colmap =>  { colmap.Key(x => x.Column("CustomerID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
