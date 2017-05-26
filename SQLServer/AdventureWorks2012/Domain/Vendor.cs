using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vendor {
        public Vendor() {
			Productvendor = new List<Productvendor>();
			Purchaseorderheader = new List<Purchaseorderheader>();
        }
        public virtual int Businessentityid { get; set; }
        public virtual Businessentity Businessentity { get; set; }
        [Required]
        [StringLength(15)]
        public virtual string Accountnumber { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        public virtual byte Creditrating { get; set; }
        [Required]
        public virtual bool Preferredvendorstatus { get; set; }
        [Required]
        public virtual bool Activeflag { get; set; }
        [StringLength(1024)]
        public virtual string Purchasingwebserviceurl { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Productvendor> Productvendor { get; set; }
        public virtual IList<Purchaseorderheader> Purchaseorderheader { get; set; }
    }
}
