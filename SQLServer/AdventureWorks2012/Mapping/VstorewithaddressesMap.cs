using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class VstorewithaddressesMap : ClassMapping<Vstorewithaddresses> {
        
        public VstorewithaddressesMap() {
			Schema("Sales");
			Lazy(true);
			Property(x => x.Businessentityid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Addresstype, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Addressline1, map => { map.NotNullable(true); map.Length(60); });
			Property(x => x.Addressline2, map => map.Length(60));
			Property(x => x.City, map => { map.NotNullable(true); map.Length(30); });
			Property(x => x.Stateprovincename, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Postalcode, map => { map.NotNullable(true); map.Length(15); });
			Property(x => x.Countryregionname, map => { map.NotNullable(true); map.Length(50); });
        }
    }
}
