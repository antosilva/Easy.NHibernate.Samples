using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Salesterritory {
        public Salesterritory() {
			Customer = new List<Customer>();
			Salesorderheader = new List<Salesorderheader>();
			Salesperson = new List<Salesperson>();
			Salesterritoryhistory = new List<Salesterritoryhistory>();
        }
        public virtual int Territoryid { get; set; }
        public virtual Countryregion Countryregion { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Group { get; set; }
        [Required]
        public virtual decimal Salesytd { get; set; }
        [Required]
        public virtual decimal Saleslastyear { get; set; }
        [Required]
        public virtual decimal Costytd { get; set; }
        [Required]
        public virtual decimal Costlastyear { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Customer> Customer { get; set; }
        public virtual IList<Salesorderheader> Salesorderheader { get; set; }
        public virtual IList<Salesperson> Salesperson { get; set; }
        public virtual IList<Salesterritoryhistory> Salesterritoryhistory { get; set; }
    }
}
