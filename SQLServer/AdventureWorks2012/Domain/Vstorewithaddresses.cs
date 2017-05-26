using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vstorewithaddresses {
        [Required]
        public virtual int Businessentityid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Addresstype { get; set; }
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
    }
}
