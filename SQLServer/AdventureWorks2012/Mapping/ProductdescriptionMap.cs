using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ProductdescriptionMap : ClassMapping<Productdescription> {
        
        public ProductdescriptionMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Productdescriptionid, map => map.Generator(Generators.Identity));
			Property(x => x.Description, map => { map.NotNullable(true); map.Length(400); });
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Productmodelproductdescriptionculture, colmap =>  { colmap.Key(x => x.Column("ProductDescriptionID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
