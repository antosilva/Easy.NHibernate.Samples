using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class SalesorderheaderMap : ClassMapping<Salesorderheader> {
        
        public SalesorderheaderMap() {
			Schema("Sales");
			Lazy(true);
			Id(x => x.Salesorderid, map => map.Generator(Generators.Identity));
			Property(x => x.Revisionnumber, map => { map.NotNullable(true); map.Precision(3); });
			Property(x => x.Orderdate, map => map.NotNullable(true));
			Property(x => x.Duedate, map => map.NotNullable(true));
			Property(x => x.Shipdate);
			Property(x => x.Status, map => { map.NotNullable(true); map.Precision(3); });
			Property(x => x.Onlineorderflag, map => map.NotNullable(true));
			Property(x => x.Salesordernumber, map => { map.NotNullable(true); map.Length(25); });
			Property(x => x.Purchaseordernumber, map => map.Length(25));
			Property(x => x.Accountnumber, map => map.Length(15));
			Property(x => x.Creditcardapprovalcode, map => map.Length(15));
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
			Property(x => x.Comment, map => map.Length(128));
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Customer, map => { map.Column("CustomerID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Salesperson, map => 
			{
				map.Column("SalesPersonID");
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

			ManyToOne(x => x.Billtoaddressid, map => { map.Column("BillToAddressID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Shiptoaddressid, map => { map.Column("ShipToAddressID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Shipmethod, map => { map.Column("ShipMethodID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Creditcard, map => 
			{
				map.Column("CreditCardID");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Currencyrate, map => 
			{
				map.Column("CurrencyRateID");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			Bag(x => x.Salesorderdetail, colmap =>  { colmap.Key(x => x.Column("SalesOrderID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Salesorderheadersalesreason, colmap =>  { colmap.Key(x => x.Column("SalesOrderID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
