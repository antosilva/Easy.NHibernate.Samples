using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vproductmodelinstructions {
        [Required]
        public virtual int Productmodelid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        public virtual string Instructions { get; set; }
        public virtual int? Locationid { get; set; }
        public virtual decimal? Setuphours { get; set; }
        public virtual decimal? Machinehours { get; set; }
        public virtual decimal? Laborhours { get; set; }
        public virtual int? Lotsize { get; set; }
        [StringLength(1024)]
        public virtual string Step { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
    }
}
