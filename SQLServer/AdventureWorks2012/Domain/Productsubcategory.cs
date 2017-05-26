using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Productsubcategory {
        public Productsubcategory() {
			Product = new List<Product>();
        }
        public virtual int Productsubcategoryid { get; set; }
        public virtual Productcategory Productcategory { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Product> Product { get; set; }
    }
}
