using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vemployee {
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
        [StringLength(25)]
        public virtual string Phonenumber { get; set; }
        [StringLength(50)]
        public virtual string Phonenumbertype { get; set; }
        [StringLength(50)]
        public virtual string Emailaddress { get; set; }
        [Required]
        public virtual int Emailpromotion { get; set; }
        [Required]
        [StringLength(60)]
        public virtual string Addressline1 { get; set; }
        [StringLength(60)]
        public virtual string Addressline2 { get; set; }
        [Required]
        [StringLength(30)]
        public virtual string City { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Stateprovincename { get; set; }
        [Required]
        [StringLength(15)]
        public virtual string Postalcode { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Countryregionname { get; set; }
        public virtual string Additionalcontactinfo { get; set; }
    }
}
