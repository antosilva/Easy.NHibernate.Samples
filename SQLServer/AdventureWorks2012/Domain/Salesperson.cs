using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Salesperson {
        public Salesperson() {
			Salesorderheader = new List<Salesorderheader>();
			Salespersonquotahistory = new List<Salespersonquotahistory>();
			Salesterritoryhistory = new List<Salesterritoryhistory>();
			Store = new List<Store>();
        }
        public virtual int Businessentityid { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Salesterritory Salesterritory { get; set; }
        public virtual decimal? Salesquota { get; set; }
        [Required]
        public virtual decimal Bonus { get; set; }
        [Required]
        public virtual decimal Commissionpct { get; set; }
        [Required]
        public virtual decimal Salesytd { get; set; }
        [Required]
        public virtual decimal Saleslastyear { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Salesorderheader> Salesorderheader { get; set; }
        public virtual IList<Salespersonquotahistory> Salespersonquotahistory { get; set; }
        public virtual IList<Salesterritoryhistory> Salesterritoryhistory { get; set; }
        public virtual IList<Store> Store { get; set; }
    }
}
