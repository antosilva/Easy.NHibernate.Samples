using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ShoppingcartitemMap : ClassMapping<Shoppingcartitem> {
        
        public ShoppingcartitemMap() {
			Schema("Sales");
			Lazy(true);
			Id(x => x.Shoppingcartitemid, map => map.Generator(Generators.Identity));
			Property(x => x.Shoppingcartid, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Quantity, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Datecreated, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Product, map => 
			{
				map.Column("ProductID");
				map.PropertyRef("Productid");
				map.Cascade(Cascade.None);
			});

        }
    }
}
