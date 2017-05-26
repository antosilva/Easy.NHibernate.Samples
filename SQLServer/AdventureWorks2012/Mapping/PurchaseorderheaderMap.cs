using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class PurchaseorderheaderMap : ClassMapping<Purchaseorderheader> {
        
        public PurchaseorderheaderMap() {
			Schema("Purchasing");
			Lazy(true);
			Id(x => x.Purchaseorderid, map => map.Generator(Generators.Identity));
			Property(x => x.Revisionnumber, map => { map.NotNullable(true); map.Precision(3); });
			Property(x => x.Status, map => { map.NotNullable(true); map.Precision(3); });
			Property(x => x.Orderdate, map => map.NotNullable(true));
			Property(x => x.Shipdate);
			Property(x => x.Subtotal, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Taxamt, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Freight, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Totaldue, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Employee, map => 
			{
				map.Column("EmployeeID");
				map.PropertyRef("Businessentityid");
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Vendor, map => { map.Column("VendorID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Shipmethod, map => { map.Column("ShipMethodID"); map.Cascade(Cascade.None); });

			Bag(x => x.Purchaseorderdetail, colmap =>  { colmap.Key(x => x.Column("PurchaseOrderID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
