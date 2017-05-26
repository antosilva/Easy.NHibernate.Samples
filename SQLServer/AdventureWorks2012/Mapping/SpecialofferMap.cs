using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class SpecialofferMap : ClassMapping<Specialoffer> {
        
        public SpecialofferMap() {
			Schema("Sales");
			Lazy(true);
			Id(x => x.Specialofferid, map => map.Generator(Generators.Identity));
			Property(x => x.Description, map => { map.NotNullable(true); map.Length(255); });
			Property(x => x.Discountpct, map => 
			{
				map.NotNullable(true);
				map.Precision(10);
				map.Scale(4);
			});
			Property(x => x.Type, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Category, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Startdate, map => map.NotNullable(true));
			Property(x => x.Enddate, map => map.NotNullable(true));
			Property(x => x.Minqty, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Maxqty, map => map.Precision(10));
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Specialofferproduct, colmap =>  { colmap.Key(x => x.Column("SpecialOfferID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
