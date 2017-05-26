using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ProductmodelMap : ClassMapping<Productmodel> {
        
        public ProductmodelMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Productmodelid, map => map.Generator(Generators.Identity));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Catalogdescription);
			Property(x => x.Instructions);
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Product, colmap =>  { colmap.Key(x => x.Column("ProductModelID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Productmodelillustration, colmap =>  { colmap.Key(x => x.Column("ProductModelID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Productmodelproductdescriptionculture, colmap =>  { colmap.Key(x => x.Column("ProductModelID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
