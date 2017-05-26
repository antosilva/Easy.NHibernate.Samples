using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ProductsMap : ClassMapping<Products> {
        
        public ProductsMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Productid, map => map.Generator(Generators.Identity));
			Property(x => x.Productname, map => { map.NotNullable(true); map.Length(40); });
			Property(x => x.Unitprice, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Discontinued, map => map.NotNullable(true));
			ManyToOne(x => x.Suppliers, map => { map.Column("supplierid"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Categories, map => { map.Column("categoryid"); map.Cascade(Cascade.None); });

        }
    }
}
