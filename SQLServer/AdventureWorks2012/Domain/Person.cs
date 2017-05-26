using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Person {
        public Person() {
			Businessentitycontact = new List<Businessentitycontact>();
			Emailaddress = new List<Emailaddress>();
			Password = new List<Password>();
			Personphone = new List<Personphone>();
        }
        public virtual int Businessentityid { get; set; }
        public virtual Businessentity Businessentity { get; set; }
        [Required]
        [StringLength(2)]
        public virtual string Persontype { get; set; }
        [Required]
        public virtual bool Namestyle { get; set; }
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
        public virtual int Emailpromotion { get; set; }
        public virtual string Additionalcontactinfo { get; set; }
        public virtual string Demographics { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Businessentitycontact> Businessentitycontact { get; set; }
        public virtual IList<Emailaddress> Emailaddress { get; set; }
        public virtual IList<Password> Password { get; set; }
        public virtual IList<Personphone> Personphone { get; set; }
    }
}
