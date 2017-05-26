using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Shipmethod {
        public Shipmethod() {
			Purchaseorderheader = new List<Purchaseorderheader>();
        }
        public virtual int Shipmethodid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        public virtual decimal Shipbase { get; set; }
        [Required]
        public virtual decimal Shiprate { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Purchaseorderheader> Purchaseorderheader { get; set; }
    }
}
