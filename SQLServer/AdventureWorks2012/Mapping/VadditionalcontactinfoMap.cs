using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class VadditionalcontactinfoMap : ClassMapping<Vadditionalcontactinfo> {
        
        public VadditionalcontactinfoMap() {
			Schema("Person");
			Lazy(true);
			Property(x => x.Businessentityid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Firstname, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Middlename, map => map.Length(50));
			Property(x => x.Lastname, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Telephonenumber, map => map.Length(50));
			Property(x => x.Telephonespecialinstructions);
			Property(x => x.Street, map => map.Length(50));
			Property(x => x.City, map => map.Length(50));
			Property(x => x.Stateprovince, map => map.Length(50));
			Property(x => x.Postalcode, map => map.Length(50));
			Property(x => x.Countryregion, map => map.Length(50));
			Property(x => x.Homeaddressspecialinstructions);
			Property(x => x.Emailaddress, map => map.Length(128));
			Property(x => x.Emailspecialinstructions);
			Property(x => x.Emailtelephonenumber, map => map.Length(50));
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
        }
    }
}
