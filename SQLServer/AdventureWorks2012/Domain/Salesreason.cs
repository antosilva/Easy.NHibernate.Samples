using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Salesreason {
        public Salesreason() {
			Salesorderheadersalesreason = new List<Salesorderheadersalesreason>();
        }
        public virtual int Salesreasonid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Reasontype { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Salesorderheadersalesreason> Salesorderheadersalesreason { get; set; }
    }
}
