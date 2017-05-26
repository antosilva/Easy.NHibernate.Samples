using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class LocationMap : ClassMapping<Location> {
        
        public LocationMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Locationid, map => map.Generator(Generators.Identity));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Costrate, map => 
			{
				map.NotNullable(true);
				map.Precision(10);
				map.Scale(4);
			});
			Property(x => x.Availability, map => 
			{
				map.NotNullable(true);
				map.Precision(8);
				map.Scale(2);
			});
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Productinventory, colmap =>  { colmap.Key(x => x.Column("LocationID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Workorderrouting, colmap =>  { colmap.Key(x => x.Column("LocationID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
