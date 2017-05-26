using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Shippers {
        public Shippers() {
			Orders = new List<Orders>();
        }
        public virtual int Shipperid { get; set; }
        [Required]
        [StringLength(40)]
        public virtual string Companyname { get; set; }
        [Required]
        [StringLength(24)]
        public virtual string Phone { get; set; }
        public virtual IList<Orders> Orders { get; set; }
    }
}
