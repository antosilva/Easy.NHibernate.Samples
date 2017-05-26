using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vadditionalcontactinfo {
        [Required]
        public virtual int Businessentityid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Firstname { get; set; }
        [StringLength(50)]
        public virtual string Middlename { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Lastname { get; set; }
        [StringLength(50)]
        public virtual string Telephonenumber { get; set; }
        public virtual string Telephonespecialinstructions { get; set; }
        [StringLength(50)]
        public virtual string Street { get; set; }
        [StringLength(50)]
        public virtual string City { get; set; }
        [StringLength(50)]
        public virtual string Stateprovince { get; set; }
        [StringLength(50)]
        public virtual string Postalcode { get; set; }
        [StringLength(50)]
        public virtual string Countryregion { get; set; }
        public virtual string Homeaddressspecialinstructions { get; set; }
        [StringLength(128)]
        public virtual string Emailaddress { get; set; }
        public virtual string Emailspecialinstructions { get; set; }
        [StringLength(50)]
        public virtual string Emailtelephonenumber { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
    }
}
