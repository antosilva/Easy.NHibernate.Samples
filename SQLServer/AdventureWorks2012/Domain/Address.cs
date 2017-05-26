using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Address {
        public Address() {
			Businessentityaddress = new List<Businessentityaddress>();
        }
        public virtual int Addressid { get; set; }
        public virtual Stateprovince Stateprovince { get; set; }
        [Required]
        [StringLength(60)]
        public virtual string Addressline1 { get; set; }
        [StringLength(60)]
        public virtual string Addressline2 { get; set; }
        [Required]
        [StringLength(30)]
        public virtual string City { get; set; }
        [Required]
        [StringLength(15)]
        public virtual string Postalcode { get; set; }
        public virtual string Spatiallocation { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Businessentityaddress> Businessentityaddress { get; set; }
    }
}
