using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Transactionhistoryarchive {
        public virtual int Transactionid { get; set; }
        [Required]
        public virtual int Productid { get; set; }
        [Required]
        public virtual int Referenceorderid { get; set; }
        [Required]
        public virtual int Referenceorderlineid { get; set; }
        [Required]
        public virtual DateTime Transactiondate { get; set; }
        [Required]
        [StringLength(1)]
        public virtual string Transactiontype { get; set; }
        [Required]
        public virtual int Quantity { get; set; }
        [Required]
        public virtual decimal Actualcost { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
    }
}
