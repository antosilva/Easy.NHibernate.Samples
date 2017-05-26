using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Creditcard {
        public Creditcard() {
			Personcreditcard = new List<Personcreditcard>();
			Salesorderheader = new List<Salesorderheader>();
        }
        public virtual int Creditcardid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Cardtype { get; set; }
        [Required]
        [StringLength(25)]
        public virtual string Cardnumber { get; set; }
        [Required]
        public virtual byte Expmonth { get; set; }
        [Required]
        public virtual short Expyear { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Personcreditcard> Personcreditcard { get; set; }
        public virtual IList<Salesorderheader> Salesorderheader { get; set; }
    }
}
