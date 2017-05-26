using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Purchaseorderheader {
        public Purchaseorderheader() {
			Purchaseorderdetail = new List<Purchaseorderdetail>();
        }
        public virtual int Purchaseorderid { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Shipmethod Shipmethod { get; set; }
        [Required]
        public virtual byte Revisionnumber { get; set; }
        [Required]
        public virtual byte Status { get; set; }
        [Required]
        public virtual DateTime Orderdate { get; set; }
        public virtual DateTime? Shipdate { get; set; }
        [Required]
        public virtual decimal Subtotal { get; set; }
        [Required]
        public virtual decimal Taxamt { get; set; }
        [Required]
        public virtual decimal Freight { get; set; }
        [Required]
        public virtual decimal Totaldue { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Purchaseorderdetail> Purchaseorderdetail { get; set; }
    }
}
