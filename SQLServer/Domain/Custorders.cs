using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Sample.CustomerService.Domain {
    
    public class Custorders {
        public virtual int? Custid { get; set; }
        public virtual DateTime? Ordermonth { get; set; }
        public virtual int? Qty { get; set; }
    }
}
