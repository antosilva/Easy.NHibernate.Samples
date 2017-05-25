using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class OrdersMap : ClassMapping<Orders> {
        
        public OrdersMap() {
			Schema("Sales");
			Lazy(true);
			Id(x => x.Orderid, map => map.Generator(Generators.Identity));
			Property(x => x.Orderdate, map => map.NotNullable(true));
			Property(x => x.Requireddate, map => map.NotNullable(true));
			Property(x => x.Shippeddate);
			Property(x => x.Freight, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Shipname, map => { map.NotNullable(true); map.Length(40); });
			Property(x => x.Shipaddress, map => { map.NotNullable(true); map.Length(60); });
			Property(x => x.Shipcity, map => { map.NotNullable(true); map.Length(15); });
			Property(x => x.Shipregion, map => map.Length(15));
			Property(x => x.Shippostalcode, map => map.Length(10));
			Property(x => x.Shipcountry, map => { map.NotNullable(true); map.Length(15); });
			ManyToOne(x => x.Customers, map => 
			{
				map.Column("custid");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Employees, map => 
			{
				map.Column("empid");
				map.PropertyRef("Empid");
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Shippers, map => { map.Column("shipperid"); map.Cascade(Cascade.None); });

			Bag(x => x.Orderdetails, colmap =>  { colmap.Key(x => x.Column("orderid")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
