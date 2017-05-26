using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class SpecialofferproductMap : ClassMapping<Specialofferproduct> {
        
        public SpecialofferproductMap() {
			Schema("Sales");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Specialofferid, m => m.Column("SpecialOfferID"));
					compId.Property(x => x.Productid, m => m.Column("ProductID"));
				});
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Specialoffer, map => { map.Column("SpecialOfferID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Product, map => 
			{
				map.Column("ProductID");
				map.PropertyRef("Productid");
				map.Cascade(Cascade.None);
			});

			Bag(x => x.Salesorderdetail, colmap =>  { colmap.Key(x => x.Column("ProductID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
