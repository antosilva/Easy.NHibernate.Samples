using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vstateprovincecountryregion {
        [Required]
        public virtual int Stateprovinceid { get; set; }
        [Required]
        [StringLength(3)]
        public virtual string Stateprovincecode { get; set; }
        [Required]
        public virtual bool Isonlystateprovinceflag { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Stateprovincename { get; set; }
        [Required]
        public virtual int Territoryid { get; set; }
        [Required]
        [StringLength(3)]
        public virtual string Countryregioncode { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Countryregionname { get; set; }
    }
}
