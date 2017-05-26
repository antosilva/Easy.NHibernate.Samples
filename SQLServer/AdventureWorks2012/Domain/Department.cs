using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Department {
        public Department() {
			Employeedepartmenthistory = new List<Employeedepartmenthistory>();
        }
        public virtual short Departmentid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Groupname { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Employeedepartmenthistory> Employeedepartmenthistory { get; set; }
    }
}
