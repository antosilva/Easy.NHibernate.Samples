using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Productdescription {
        public Productdescription() {
			Productmodelproductdescriptionculture = new List<Productmodelproductdescriptionculture>();
        }
        public virtual int Productdescriptionid { get; set; }
        [Required]
        [StringLength(400)]
        public virtual string Description { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Productmodelproductdescriptionculture> Productmodelproductdescriptionculture { get; set; }
    }
}
