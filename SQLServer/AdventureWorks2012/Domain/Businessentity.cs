using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Businessentity {
        public Businessentity() {
			Businessentityaddress = new List<Businessentityaddress>();
			Businessentitycontact = new List<Businessentitycontact>();
			Person = new List<Person>();
        }
        public virtual int Businessentityid { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Businessentityaddress> Businessentityaddress { get; set; }
        public virtual IList<Businessentitycontact> Businessentitycontact { get; set; }
        public virtual IList<Person> Person { get; set; }
    }
}
