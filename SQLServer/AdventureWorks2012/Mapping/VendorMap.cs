using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class VendorMap : ClassMapping<Vendor> {
        
        public VendorMap() {
			Schema("Purchasing");
			Lazy(true);
			Id(x => x.Businessentityid, map => map.Generator(Generators.Assigned));
			Property(x => x.Accountnumber, map => { map.NotNullable(true); map.Length(15); });
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Creditrating, map => { map.NotNullable(true); map.Precision(3); });
			Property(x => x.Preferredvendorstatus, map => map.NotNullable(true));
			Property(x => x.Activeflag, map => map.NotNullable(true));
			Property(x => x.Purchasingwebserviceurl, map => map.Length(1024));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Businessentity, map => { map.Column("BusinessEntityID"); map.Cascade(Cascade.None); });

			Bag(x => x.Productvendor, colmap =>  { colmap.Key(x => x.Column("BusinessEntityID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Purchaseorderheader, colmap =>  { colmap.Key(x => x.Column("VendorID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
