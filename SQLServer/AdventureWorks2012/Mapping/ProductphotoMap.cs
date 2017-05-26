using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ProductphotoMap : ClassMapping<Productphoto> {
        
        public ProductphotoMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Productphotoid, map => map.Generator(Generators.Identity));
			Property(x => x.Thumbnailphoto);
			Property(x => x.Thumbnailphotofilename, map => map.Length(50));
			Property(x => x.Largephoto);
			Property(x => x.Largephotofilename, map => map.Length(50));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Productproductphoto, colmap =>  { colmap.Key(x => x.Column("ProductPhotoID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
