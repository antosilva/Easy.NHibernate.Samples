using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class AddressMap : ClassMapping<Address> {
        
        public AddressMap() {
			Schema("Person");
			Lazy(true);
			Id(x => x.Addressid, map => map.Generator(Generators.Identity));
			Property(x => x.Addressline1, map => { map.NotNullable(true); map.Length(60); });
			Property(x => x.Addressline2, map => map.Length(60));
			Property(x => x.City, map => { map.NotNullable(true); map.Length(30); });
			Property(x => x.Postalcode, map => { map.NotNullable(true); map.Length(15); });
			Property(x => x.Spatiallocation);
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Stateprovince, map => { map.Column("StateProvinceID"); map.Cascade(Cascade.None); });

			Bag(x => x.Businessentityaddress, colmap =>  { colmap.Key(x => x.Column("AddressID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
