using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Salestaxrate {
        public virtual int Salestaxrateid { get; set; }
        public virtual Stateprovince Stateprovince { get; set; }
        [Required]
        public virtual byte Taxtype { get; set; }
        [Required]
        public virtual decimal Taxrate { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
    }
}
