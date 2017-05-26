using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Productmodel {
        public Productmodel() {
			Product = new List<Product>();
			Productmodelillustration = new List<Productmodelillustration>();
			Productmodelproductdescriptionculture = new List<Productmodelproductdescriptionculture>();
        }
        public virtual int Productmodelid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        public virtual string Catalogdescription { get; set; }
        public virtual string Instructions { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Product> Product { get; set; }
        public virtual IList<Productmodelillustration> Productmodelillustration { get; set; }
        public virtual IList<Productmodelproductdescriptionculture> Productmodelproductdescriptionculture { get; set; }
    }
}
