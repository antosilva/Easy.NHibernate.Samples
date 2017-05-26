using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class OrdertotalsbyyearMap : ClassMapping<Ordertotalsbyyear> {
        
        public OrdertotalsbyyearMap() {
			Schema("Sales");
			Lazy(true);
			Property(x => x.Orderyear, map => map.Precision(10));
			Property(x => x.Qty, map => map.Precision(10));
        }
    }
}
