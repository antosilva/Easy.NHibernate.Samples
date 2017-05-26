using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class VvendorwithcontactsMap : ClassMapping<Vvendorwithcontacts> {
        
        public VvendorwithcontactsMap() {
			Schema("Purchasing");
			Lazy(true);
			Property(x => x.Businessentityid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Contacttype, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Title, map => map.Length(8));
			Property(x => x.Firstname, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Middlename, map => map.Length(50));
			Property(x => x.Lastname, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Suffix, map => map.Length(10));
			Property(x => x.Phonenumber, map => map.Length(25));
			Property(x => x.Phonenumbertype, map => map.Length(50));
			Property(x => x.Emailaddress, map => map.Length(50));
			Property(x => x.Emailpromotion, map => { map.NotNullable(true); map.Precision(10); });
        }
    }
}
