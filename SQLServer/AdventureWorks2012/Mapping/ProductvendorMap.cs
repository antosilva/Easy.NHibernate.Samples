using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ProductvendorMap : ClassMapping<Productvendor> {
        
        public ProductvendorMap() {
			Schema("Purchasing");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Productid, m => m.Column("ProductID"));
					compId.Property(x => x.Businessentityid, m => m.Column("BusinessEntityID"));
				});
			Property(x => x.Averageleadtime, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Standardprice, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Lastreceiptcost, map => { map.Precision(19); map.Scale(4); });
			Property(x => x.Lastreceiptdate);
			Property(x => x.Minorderqty, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Maxorderqty, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Onorderqty, map => map.Precision(10));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Product, map => 
			{
				map.Column("ProductID");
				map.PropertyRef("Productid");
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Vendor, map => { map.Column("BusinessEntityID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Unitmeasure, map => { map.Column("UnitMeasureCode"); map.Cascade(Cascade.None); });

        }
    }
}
