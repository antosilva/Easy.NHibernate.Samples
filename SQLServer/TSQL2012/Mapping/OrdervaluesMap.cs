using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class OrdervaluesMap : ClassMapping<Ordervalues> {
        
        public OrdervaluesMap() {
			Schema("Sales");
			Lazy(true);
			Property(x => x.Orderid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Custid, map => map.Precision(10));
			Property(x => x.Empid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Shipperid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Orderdate, map => map.NotNullable(true));
			Property(x => x.Requireddate, map => map.NotNullable(true));
			Property(x => x.Shippeddate);
			Property(x => x.Qty, map => map.Precision(10));
			Property(x => x.Val, map => { map.Precision(12); map.Scale(2); });
        }
    }
}
