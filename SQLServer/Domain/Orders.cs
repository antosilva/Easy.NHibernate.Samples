using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Sample.CustomerService.Domain {
    
    public class Orders {
        public Orders() {
			Orderdetails = new List<Orderdetails>();
        }
        public virtual int Orderid { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Shippers Shippers { get; set; }
        [NotNullNotEmpty]
        public virtual DateTime Orderdate { get; set; }
        [NotNullNotEmpty]
        public virtual DateTime Requireddate { get; set; }
        public virtual DateTime? Shippeddate { get; set; }
        [NotNullNotEmpty]
        public virtual decimal Freight { get; set; }
        [NotNullNotEmpty]
        [Length(40)]
        public virtual string Shipname { get; set; }
        [NotNullNotEmpty]
        [Length(60)]
        public virtual string Shipaddress { get; set; }
        [NotNullNotEmpty]
        [Length(15)]
        public virtual string Shipcity { get; set; }
        [Length(15)]
        public virtual string Shipregion { get; set; }
        [Length(10)]
        public virtual string Shippostalcode { get; set; }
        [NotNullNotEmpty]
        [Length(15)]
        public virtual string Shipcountry { get; set; }
        public virtual IList<Orderdetails> Orderdetails { get; set; }
    }
}
