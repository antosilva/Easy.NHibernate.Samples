using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Currency {
        public Currency() {
			Countryregioncurrency = new List<Countryregioncurrency>();
			Currencyrate = new List<Currencyrate>();
			Currencyrate = new List<Currencyrate>();
        }
        public virtual string Currencycode { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Countryregioncurrency> Countryregioncurrency { get; set; }
        public virtual IList<Currencyrate> Currencyrate { get; set; }
        public virtual IList<Currencyrate> Currencyrate { get; set; }
    }
}
