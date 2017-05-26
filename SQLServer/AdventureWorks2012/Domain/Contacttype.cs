using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Contacttype {
        public Contacttype() {
			Businessentitycontact = new List<Businessentitycontact>();
        }
        public virtual int Contacttypeid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Businessentitycontact> Businessentitycontact { get; set; }
    }
}
