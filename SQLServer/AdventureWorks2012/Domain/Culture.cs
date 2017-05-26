using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Culture {
        public Culture() {
			Productmodelproductdescriptionculture = new List<Productmodelproductdescriptionculture>();
        }
        public virtual string Cultureid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Productmodelproductdescriptionculture> Productmodelproductdescriptionculture { get; set; }
    }
}
