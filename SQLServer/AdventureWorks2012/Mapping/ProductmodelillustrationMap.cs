using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ProductmodelillustrationMap : ClassMapping<Productmodelillustration> {
        
        public ProductmodelillustrationMap() {
			Schema("Production");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Productmodelid, m => m.Column("ProductModelID"));
					compId.Property(x => x.Illustrationid, m => m.Column("IllustrationID"));
				});
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Productmodel, map => { map.Column("ProductModelID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Illustration, map => { map.Column("IllustrationID"); map.Cascade(Cascade.None); });

        }
    }
}
