using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class SalesorderdetailMap : ClassMapping<Salesorderdetail> {
        
        public SalesorderdetailMap() {
			Schema("Sales");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Salesorderid, m => m.Column("SalesOrderID"));
					compId.Property(x => x.Salesorderdetailid, m => m.Column("SalesOrderDetailID"));
				});
			Property(x => x.Carriertrackingnumber, map => map.Length(25));
			Property(x => x.Orderqty, map => { map.NotNullable(true); map.Precision(5); });
			Property(x => x.Unitprice, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Unitpricediscount, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Linetotal, map => 
			{
				map.NotNullable(true);
				map.Precision(38);
				map.Scale(6);
			});
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Salesorderheader, map => { map.Column("SalesOrderID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Specialofferproduct, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("ProductID"), x => x.Name("SpecialOfferID") }));
        }
    }
}
