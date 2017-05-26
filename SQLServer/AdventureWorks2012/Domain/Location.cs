using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Location {
        public Location() {
			Productinventory = new List<Productinventory>();
			Workorderrouting = new List<Workorderrouting>();
        }
        public virtual short Locationid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        public virtual decimal Costrate { get; set; }
        [Required]
        public virtual decimal Availability { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Productinventory> Productinventory { get; set; }
        public virtual IList<Workorderrouting> Workorderrouting { get; set; }
    }
}
