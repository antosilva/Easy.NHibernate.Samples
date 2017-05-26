using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Stateprovince {
        public Stateprovince() {
			Address = new List<Address>();
        }
        public virtual int Stateprovinceid { get; set; }
        public virtual Countryregion Countryregion { get; set; }
        public virtual Salesterritory Salesterritory { get; set; }
        [Required]
        [StringLength(3)]
        public virtual string Stateprovincecode { get; set; }
        [Required]
        public virtual bool Isonlystateprovinceflag { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Address> Address { get; set; }
    }
}
