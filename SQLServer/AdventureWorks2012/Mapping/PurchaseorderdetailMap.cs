using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class PurchaseorderdetailMap : ClassMapping<Purchaseorderdetail> {
        
        public PurchaseorderdetailMap() {
			Schema("Purchasing");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Purchaseorderid, m => m.Column("PurchaseOrderID"));
					compId.Property(x => x.Purchaseorderdetailid, m => m.Column("PurchaseOrderDetailID"));
				});
			Property(x => x.Duedate, map => map.NotNullable(true));
			Property(x => x.Orderqty, map => { map.NotNullable(true); map.Precision(5); });
			Property(x => x.Unitprice, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Linetotal, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Receivedqty, map => 
			{
				map.NotNullable(true);
				map.Precision(8);
				map.Scale(2);
			});
			Property(x => x.Rejectedqty, map => 
			{
				map.NotNullable(true);
				map.Precision(8);
				map.Scale(2);
			});
			Property(x => x.Stockedqty, map => 
			{
				map.NotNullable(true);
				map.Precision(9);
				map.Scale(2);
			});
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Purchaseorderheader, map => { map.Column("PurchaseOrderID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Product, map => 
			{
				map.Column("ProductID");
				map.PropertyRef("Productid");
				map.Cascade(Cascade.None);
			});

        }
    }
}
