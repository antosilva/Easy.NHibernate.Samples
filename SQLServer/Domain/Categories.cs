using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Sample.CustomerService.Domain {
    
    public class Categories {
        public Categories() {
			Products = new List<Products>();
        }
        public virtual int Categoryid { get; set; }
        [NotNullNotEmpty]
        [Length(15)]
        public virtual string Categoryname { get; set; }
        [NotNullNotEmpty]
        [Length(200)]
        public virtual string Description { get; set; }
        public virtual IList<Products> Products { get; set; }
    }
}
