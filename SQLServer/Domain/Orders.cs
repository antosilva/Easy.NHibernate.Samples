using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Orders {
        public Orders() {
			Orderdetails = new List<Orderdetails>();
        }
        public virtual int Orderid { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Shippers Shippers { get; set; }
        [Required]
        public virtual DateTime Orderdate { get; set; }
        [Required]
        public virtual DateTime Requireddate { get; set; }
        public virtual DateTime? Shippeddate { get; set; }
        [Required]
        public virtual decimal Freight { get; set; }
        [Required]
        [StringLength(40)]
        public virtual string Shipname { get; set; }
        [Required]
        [StringLength(60)]
        public virtual string Shipaddress { get; set; }
        [Required]
        [StringLength(15)]
        public virtual string Shipcity { get; set; }
        [StringLength(15)]
        public virtual string Shipregion { get; set; }
        [StringLength(10)]
        public virtual string Shippostalcode { get; set; }
        [Required]
        [StringLength(15)]
        public virtual string Shipcountry { get; set; }
        public virtual IList<Orderdetails> Orderdetails { get; set; }
    }
}
