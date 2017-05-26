using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ProductsubcategoryMap : ClassMapping<Productsubcategory> {
        
        public ProductsubcategoryMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Productsubcategoryid, map => map.Generator(Generators.Identity));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Productcategory, map => { map.Column("ProductCategoryID"); map.Cascade(Cascade.None); });

			Bag(x => x.Product, colmap =>  { colmap.Key(x => x.Column("ProductSubcategoryID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
