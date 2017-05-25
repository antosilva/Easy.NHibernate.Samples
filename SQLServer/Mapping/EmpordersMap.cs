using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class EmpordersMap : ClassMapping<Emporders> {
        
        public EmpordersMap() {
			Schema("Sales");
			Lazy(true);
			Property(x => x.Empid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Ordermonth);
			Property(x => x.Qty, map => map.Precision(10));
			Property(x => x.Val, map => { map.Precision(12); map.Scale(2); });
			Property(x => x.Numorders, map => map.Precision(10));
        }
    }
}
