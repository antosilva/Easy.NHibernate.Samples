using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class CategoriesMap : ClassMapping<Categories> {
        
        public CategoriesMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Categoryid, map => map.Generator(Generators.Identity));
			Property(x => x.Categoryname, map => { map.NotNullable(true); map.Length(15); });
			Property(x => x.Description, map => { map.NotNullable(true); map.Length(200); });
			Bag(x => x.Products, colmap =>  { colmap.Key(x => x.Column("categoryid")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
