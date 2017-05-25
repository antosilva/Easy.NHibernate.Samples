using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Sample.CustomerService.Domain {
    
    public class Shippers {
        public Shippers() {
			Orders = new List<Orders>();
        }
        public virtual int Shipperid { get; set; }
        [NotNullNotEmpty]
        [Length(40)]
        public virtual string Companyname { get; set; }
        [NotNullNotEmpty]
        [Length(24)]
        public virtual string Phone { get; set; }
        public virtual IList<Orders> Orders { get; set; }
    }
}
