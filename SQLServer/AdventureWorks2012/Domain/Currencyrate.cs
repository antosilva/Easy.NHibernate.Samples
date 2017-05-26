using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Currencyrate {
        public Currencyrate() {
			Salesorderheader = new List<Salesorderheader>();
        }
        public virtual int Currencyrateid { get; set; }
        public virtual Currency Currency { get; set; }
        [Required]
        public virtual DateTime Currencyratedate { get; set; }
        [Required]
        public virtual decimal Averagerate { get; set; }
        [Required]
        public virtual decimal Endofdayrate { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Salesorderheader> Salesorderheader { get; set; }
    }
}
