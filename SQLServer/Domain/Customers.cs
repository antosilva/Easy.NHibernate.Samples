using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Sample.CustomerService.Domain {
    
    public class Customers {
        public Customers() {
			Orders = new List<Orders>();
        }
        public virtual int Custid { get; set; }
        [NotNullNotEmpty]
        [Length(40)]
        public virtual string Companyname { get; set; }
        [NotNullNotEmpty]
        [Length(30)]
        public virtual string Contactname { get; set; }
        [NotNullNotEmpty]
        [Length(30)]
        public virtual string Contacttitle { get; set; }
        [NotNullNotEmpty]
        [Length(60)]
        public virtual string Address { get; set; }
        [NotNullNotEmpty]
        [Length(15)]
        public virtual string City { get; set; }
        [Length(15)]
        public virtual string Region { get; set; }
        [Length(10)]
        public virtual string Postalcode { get; set; }
        [NotNullNotEmpty]
        [Length(15)]
        public virtual string Country { get; set; }
        [NotNullNotEmpty]
        [Length(24)]
        public virtual string Phone { get; set; }
        [Length(24)]
        public virtual string Fax { get; set; }
        public virtual IList<Orders> Orders { get; set; }
    }
}
