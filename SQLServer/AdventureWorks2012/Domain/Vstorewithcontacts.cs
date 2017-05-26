using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vstorewithcontacts {
        [Required]
        public virtual int Businessentityid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Contacttype { get; set; }
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
        [StringLength(25)]
        public virtual string Phonenumber { get; set; }
        [StringLength(50)]
        public virtual string Phonenumbertype { get; set; }
        [StringLength(50)]
        public virtual string Emailaddress { get; set; }
        [Required]
        public virtual int Emailpromotion { get; set; }
    }
}
