using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vemployeedepartment {
        [Required]
        public virtual int Businessentityid { get; set; }
        [StringLength(8)]
        public virtual string Title { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Firstname { get; set; }
        [StringLength(50)]
        public virtual string Middlename { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Lastname { get; set; }
        [StringLength(10)]
        public virtual string Suffix { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Jobtitle { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Department { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Groupname { get; set; }
        [Required]
        public virtual DateTime Startdate { get; set; }
    }
}
