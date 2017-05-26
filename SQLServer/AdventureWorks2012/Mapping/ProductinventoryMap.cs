using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ProductinventoryMap : ClassMapping<Productinventory> {
        
        public ProductinventoryMap() {
			Schema("Production");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Productid, m => m.Column("ProductID"));
					compId.Property(x => x.Locationid, m => m.Column("LocationID"));
				});
			Property(x => x.Shelf, map => { map.NotNullable(true); map.Length(10); });
			Property(x => x.Bin, map => { map.NotNullable(true); map.Precision(3); });
			Property(x => x.Quantity, map => { map.NotNullable(true); map.Precision(5); });
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Product, map => 
			{
				map.Column("ProductID");
				map.PropertyRef("Productid");
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Location, map => 
			{
				map.Column("LocationID");
				map.PropertyRef("Locationid");
				map.Cascade(Cascade.None);
			});

        }
    }
}
