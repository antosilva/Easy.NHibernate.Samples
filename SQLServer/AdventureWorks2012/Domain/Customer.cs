using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Customer {
        public Customer() {
			Salesorderheader = new List<Salesorderheader>();
        }
        public virtual int Customerid { get; set; }
        public virtual Person Person { get; set; }
        public virtual Store Store { get; set; }
        public virtual Salesterritory Salesterritory { get; set; }
        [Required]
        [StringLength(10)]
        public virtual string Accountnumber { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Salesorderheader> Salesorderheader { get; set; }
    }
}
