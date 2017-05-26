using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Phonenumbertype {
        public Phonenumbertype() {
			Personphone = new List<Personphone>();
        }
        public virtual int Phonenumbertypeid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Personphone> Personphone { get; set; }
    }
}
