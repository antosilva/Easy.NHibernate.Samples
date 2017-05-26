using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ProductreviewMap : ClassMapping<Productreview> {
        
        public ProductreviewMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Productreviewid, map => map.Generator(Generators.Identity));
			Property(x => x.Reviewername, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Reviewdate, map => map.NotNullable(true));
			Property(x => x.Emailaddress, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Rating, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Comments, map => map.Length(3850));
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
