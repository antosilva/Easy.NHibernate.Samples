using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Specialoffer {
        public Specialoffer() {
			Specialofferproduct = new List<Specialofferproduct>();
        }
        public virtual int Specialofferid { get; set; }
        [Required]
        [StringLength(255)]
        public virtual string Description { get; set; }
        [Required]
        public virtual decimal Discountpct { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Type { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Category { get; set; }
        [Required]
        public virtual DateTime Startdate { get; set; }
        [Required]
        public virtual DateTime Enddate { get; set; }
        [Required]
        public virtual int Minqty { get; set; }
        public virtual int? Maxqty { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Specialofferproduct> Specialofferproduct { get; set; }
    }
}
