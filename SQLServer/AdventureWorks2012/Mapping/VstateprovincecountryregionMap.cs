using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class VstateprovincecountryregionMap : ClassMapping<Vstateprovincecountryregion> {
        
        public VstateprovincecountryregionMap() {
			Schema("Person");
			Lazy(true);
			Property(x => x.Stateprovinceid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Stateprovincecode, map => { map.NotNullable(true); map.Length(3); });
			Property(x => x.Isonlystateprovinceflag, map => map.NotNullable(true));
			Property(x => x.Stateprovincename, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Territoryid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Countryregioncode, map => { map.NotNullable(true); map.Length(3); });
			Property(x => x.Countryregionname, map => { map.NotNullable(true); map.Length(50); });
        }
    }
}
