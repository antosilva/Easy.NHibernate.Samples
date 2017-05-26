using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Addresstype {
        public Addresstype() {
			Businessentityaddress = new List<Businessentityaddress>();
        }
        public virtual int Addresstypeid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Businessentityaddress> Businessentityaddress { get; set; }
    }
}
