using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Customers {
        public Customers() {
			Orders = new List<Orders>();
        }
        public virtual int Custid { get; set; }
        [Required]
        [StringLength(40)]
        public virtual string Companyname { get; set; }
        [Required]
        [StringLength(30)]
        public virtual string Contactname { get; set; }
        [Required]
        [StringLength(30)]
        public virtual string Contacttitle { get; set; }
        [Required]
        [StringLength(60)]
        public virtual string Address { get; set; }
        [Required]
        [StringLength(15)]
        public virtual string City { get; set; }
        [StringLength(15)]
        public virtual string Region { get; set; }
        [StringLength(10)]
        public virtual string Postalcode { get; set; }
        [Required]
        [StringLength(15)]
        public virtual string Country { get; set; }
        [Required]
        [StringLength(24)]
        public virtual string Phone { get; set; }
        [StringLength(24)]
        public virtual string Fax { get; set; }
        public virtual IList<Orders> Orders { get; set; }
    }
}
