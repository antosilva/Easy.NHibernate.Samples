using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Ordervalues {
        [Required]
        public virtual int Orderid { get; set; }
        public virtual int? Custid { get; set; }
        [Required]
        public virtual int Empid { get; set; }
        [Required]
        public virtual int Shipperid { get; set; }
        [Required]
        public virtual DateTime Orderdate { get; set; }
        [Required]
        public virtual DateTime Requireddate { get; set; }
        public virtual DateTime? Shippeddate { get; set; }
        public virtual int? Qty { get; set; }
        public virtual double? Val { get; set; }
    }
}
