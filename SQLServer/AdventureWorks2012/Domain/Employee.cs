using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Employee {
        public Employee() {
			Employeedepartmenthistory = new List<Employeedepartmenthistory>();
			Employeepayhistory = new List<Employeepayhistory>();
			Jobcandidate = new List<Jobcandidate>();
        }
        public virtual int Businessentityid { get; set; }
        public virtual Person Person { get; set; }
        [Required]
        [StringLength(15)]
        public virtual string Nationalidnumber { get; set; }
        [Required]
        [StringLength(256)]
        public virtual string Loginid { get; set; }
        [StringLength(892)]
        public virtual string Organizationnode { get; set; }
        public virtual short? Organizationlevel { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Jobtitle { get; set; }
        [Required]
        public virtual DateTime Birthdate { get; set; }
        [Required]
        [StringLength(1)]
        public virtual string Maritalstatus { get; set; }
        [Required]
        [StringLength(1)]
        public virtual string Gender { get; set; }
        [Required]
        public virtual DateTime Hiredate { get; set; }
        [Required]
        public virtual bool Salariedflag { get; set; }
        [Required]
        public virtual short Vacationhours { get; set; }
        [Required]
        public virtual short Sickleavehours { get; set; }
        [Required]
        public virtual bool Currentflag { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Employeedepartmenthistory> Employeedepartmenthistory { get; set; }
        public virtual IList<Employeepayhistory> Employeepayhistory { get; set; }
        public virtual IList<Jobcandidate> Jobcandidate { get; set; }
    }
}
