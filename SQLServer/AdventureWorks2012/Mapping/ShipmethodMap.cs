using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ShipmethodMap : ClassMapping<Shipmethod> {
        
        public ShipmethodMap() {
			Schema("Purchasing");
			Lazy(true);
			Id(x => x.Shipmethodid, map => map.Generator(Generators.Identity));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Shipbase, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Shiprate, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Purchaseorderheader, colmap =>  { colmap.Key(x => x.Column("ShipMethodID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
