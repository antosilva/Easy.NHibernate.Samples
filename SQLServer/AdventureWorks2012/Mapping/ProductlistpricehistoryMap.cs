using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ProductlistpricehistoryMap : ClassMapping<Productlistpricehistory> {
        
        public ProductlistpricehistoryMap() {
			Schema("Production");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Productid, m => m.Column("ProductID"));
					compId.Property(x => x.Startdate, m => m.Column("StartDate"));
				});
			Property(x => x.Enddate);
			Property(x => x.Listprice, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
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
