using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Scrapreason {
        public Scrapreason() {
			Workorder = new List<Workorder>();
        }
        public virtual short Scrapreasonid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Workorder> Workorder { get; set; }
    }
}
