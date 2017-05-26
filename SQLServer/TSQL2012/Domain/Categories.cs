using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Categories {
        public Categories() {
			Products = new List<Products>();
        }
        public virtual int Categoryid { get; set; }
        [Required]
        [StringLength(15)]
        public virtual string Categoryname { get; set; }
        [Required]
        [StringLength(200)]
        public virtual string Description { get; set; }
        public virtual IList<Products> Products { get; set; }
    }
}
