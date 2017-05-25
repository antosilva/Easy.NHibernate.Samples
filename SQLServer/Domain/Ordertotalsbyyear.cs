using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Sample.CustomerService.Domain {
    
    public class Ordertotalsbyyear {
        public virtual int? Orderyear { get; set; }
        public virtual int? Qty { get; set; }
    }
}
