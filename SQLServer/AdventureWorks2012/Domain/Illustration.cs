using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Illustration {
        public Illustration() {
			Productmodelillustration = new List<Productmodelillustration>();
        }
        public virtual int Illustrationid { get; set; }
        public virtual string Diagram { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Productmodelillustration> Productmodelillustration { get; set; }
    }
}
