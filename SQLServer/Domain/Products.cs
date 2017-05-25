using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Sample.CustomerService.Domain {
    
    public class Products {
        public virtual int Productid { get; set; }
        public virtual Suppliers Suppliers { get; set; }
        public virtual Categories Categories { get; set; }
        [NotNullNotEmpty]
        [Length(40)]
        public virtual string Productname { get; set; }
        [NotNullNotEmpty]
        public virtual decimal Unitprice { get; set; }
        [NotNullNotEmpty]
        public virtual bool Discontinued { get; set; }
    }
}
