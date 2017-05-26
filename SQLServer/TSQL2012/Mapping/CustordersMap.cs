using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class CustordersMap : ClassMapping<Custorders> {
        
        public CustordersMap() {
			Schema("Sales");
			Lazy(true);
			Property(x => x.Custid, map => map.Precision(10));
			Property(x => x.Ordermonth);
			Property(x => x.Qty, map => map.Precision(10));
        }
    }
}
