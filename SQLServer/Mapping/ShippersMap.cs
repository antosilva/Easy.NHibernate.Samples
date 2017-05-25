using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ShippersMap : ClassMapping<Shippers> {
        
        public ShippersMap() {
			Schema("Sales");
			Lazy(true);
			Id(x => x.Shipperid, map => map.Generator(Generators.Identity));
			Property(x => x.Companyname, map => { map.NotNullable(true); map.Length(40); });
			Property(x => x.Phone, map => { map.NotNullable(true); map.Length(24); });
			Bag(x => x.Orders, colmap =>  { colmap.Key(x => x.Column("shipperid")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
