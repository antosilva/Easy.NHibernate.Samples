using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Unitmeasure {
        public Unitmeasure() {
			Billofmaterials = new List<Billofmaterials>();
			Product = new List<Product>();
			Product = new List<Product>();
        }
        public virtual string Unitmeasurecode { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Billofmaterials> Billofmaterials { get; set; }
        public virtual IList<Product> Product { get; set; }
        public virtual IList<Product> Product { get; set; }
    }
}
