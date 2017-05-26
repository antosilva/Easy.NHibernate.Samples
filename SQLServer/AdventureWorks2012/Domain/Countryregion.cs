using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Countryregion {
        public Countryregion() {
			Stateprovince = new List<Stateprovince>();
        }
        public virtual string Countryregioncode { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Stateprovince> Stateprovince { get; set; }
    }
}
