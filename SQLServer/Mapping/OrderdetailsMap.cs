using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class OrderdetailsMap : ClassMapping<Orderdetails> {
        
        public OrderdetailsMap() {
			Schema("Sales");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Orderid, m => m.Column("orderid"));
					compId.Property(x => x.Productid, m => m.Column("productid"));
				});
			Property(x => x.Unitprice, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Qty, map => { map.NotNullable(true); map.Precision(5); });
			Property(x => x.Discount, map => 
			{
				map.NotNullable(true);
				map.Precision(4);
				map.Scale(3);
			});
			ManyToOne(x => x.Orders, map => 
			{
				map.Column("orderid");
				map.PropertyRef("Orderid");
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Products, map => 
			{
				map.Column("productid");
				map.PropertyRef("Productid");
				map.Cascade(Cascade.None);
			});

        }
    }
}
