using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ProductproductphotoMap : ClassMapping<Productproductphoto> {
        
        public ProductproductphotoMap() {
			Schema("Production");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Productid, m => m.Column("ProductID"));
					compId.Property(x => x.Productphotoid, m => m.Column("ProductPhotoID"));
				});
			Property(x => x.Primary, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Product, map => 
			{
				map.Column("ProductID");
				map.PropertyRef("Productid");
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Productphoto, map => { map.Column("ProductPhotoID"); map.Cascade(Cascade.None); });

        }
    }
}
