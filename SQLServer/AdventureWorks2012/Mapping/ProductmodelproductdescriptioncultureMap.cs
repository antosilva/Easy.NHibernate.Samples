using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ProductmodelproductdescriptioncultureMap : ClassMapping<Productmodelproductdescriptionculture> {
        
        public ProductmodelproductdescriptioncultureMap() {
			Schema("Production");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Productmodelid, m => m.Column("ProductModelID"));
					compId.Property(x => x.Productdescriptionid, m => m.Column("ProductDescriptionID"));
					compId.Property(x => x.Cultureid, m => m.Column("CultureID"));
				});
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Productmodel, map => { map.Column("ProductModelID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Productdescription, map => { map.Column("ProductDescriptionID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Culture, map => { map.Column("CultureID"); map.Cascade(Cascade.None); });

        }
    }
}
