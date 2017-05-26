using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class VsalespersonsalesbyfiscalyearsMap : ClassMapping<Vsalespersonsalesbyfiscalyears> {
        
        public VsalespersonsalesbyfiscalyearsMap() {
			Schema("Sales");
			Lazy(true);
			Property(x => x.Salespersonid, map => map.Precision(10));
			Property(x => x.Fullname, map => map.Length(152));
			Property(x => x.Jobtitle, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Salesterritory, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.2002, map => { map.Precision(19); map.Scale(4); });
			Property(x => x.2003, map => { map.Precision(19); map.Scale(4); });
			Property(x => x.2004, map => { map.Precision(19); map.Scale(4); });
        }
    }
}
