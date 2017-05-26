using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Billofmaterials {
        public virtual int Billofmaterialsid { get; set; }
        public virtual Product Product { get; set; }
        public virtual Unitmeasure Unitmeasure { get; set; }
        [Required]
        public virtual DateTime Startdate { get; set; }
        public virtual DateTime? Enddate { get; set; }
        [Required]
        public virtual short Bomlevel { get; set; }
        [Required]
        public virtual decimal Perassemblyqty { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
    }
}
