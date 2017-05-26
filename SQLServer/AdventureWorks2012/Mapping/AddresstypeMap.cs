using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class AddresstypeMap : ClassMapping<Addresstype> {
        
        public AddresstypeMap() {
			Schema("Person");
			Lazy(true);
			Id(x => x.Addresstypeid, map => map.Generator(Generators.Identity));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Businessentityaddress, colmap =>  { colmap.Key(x => x.Column("AddressTypeID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
