using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Sample.CustomerService.Domain {
    
    public class Emporders {
        [NotNullNotEmpty]
        public virtual int Empid { get; set; }
        public virtual DateTime? Ordermonth { get; set; }
        public virtual int? Qty { get; set; }
        public virtual double? Val { get; set; }
        public virtual int? Numorders { get; set; }
    }
}
