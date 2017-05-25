using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Sample.CustomerService.Domain {
    
    public class Ordervalues {
        [NotNullNotEmpty]
        public virtual int Orderid { get; set; }
        public virtual int? Custid { get; set; }
        [NotNullNotEmpty]
        public virtual int Empid { get; set; }
        [NotNullNotEmpty]
        public virtual int Shipperid { get; set; }
        [NotNullNotEmpty]
        public virtual DateTime Orderdate { get; set; }
        [NotNullNotEmpty]
        public virtual DateTime Requireddate { get; set; }
        public virtual DateTime? Shippeddate { get; set; }
        public virtual int? Qty { get; set; }
        public virtual double? Val { get; set; }
    }
}
