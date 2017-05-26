using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vproductanddescription {
        [Required]
        public virtual int Productid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Productmodel { get; set; }
        [Required]
        [StringLength(6)]
        public virtual string Cultureid { get; set; }
        [Required]
        [StringLength(400)]
        public virtual string Description { get; set; }
    }
}
