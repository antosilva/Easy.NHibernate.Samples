using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Products {
        public virtual int Productid { get; set; }
        public virtual Suppliers Suppliers { get; set; }
        public virtual Categories Categories { get; set; }
        [Required]
        [StringLength(40)]
        public virtual string Productname { get; set; }
        [Required]
        public virtual decimal Unitprice { get; set; }
        [Required]
        public virtual bool Discontinued { get; set; }
    }
}
