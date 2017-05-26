using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Shift {
        public Shift() {
			Employeedepartmenthistory = new List<Employeedepartmenthistory>();
        }
        public virtual byte Shiftid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        public virtual DateTime Starttime { get; set; }
        [Required]
        public virtual DateTime Endtime { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Employeedepartmenthistory> Employeedepartmenthistory { get; set; }
    }
}
