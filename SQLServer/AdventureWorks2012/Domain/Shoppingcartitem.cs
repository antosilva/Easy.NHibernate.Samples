using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Shoppingcartitem {
        public virtual int Shoppingcartitemid { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Shoppingcartid { get; set; }
        [Required]
        public virtual int Quantity { get; set; }
        [Required]
        public virtual DateTime Datecreated { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
    }
}
