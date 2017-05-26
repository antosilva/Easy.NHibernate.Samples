using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Password {
        public virtual int Businessentityid { get; set; }
        public virtual Person Person { get; set; }
        [Required]
        [StringLength(128)]
        public virtual string Passwordhash { get; set; }
        [Required]
        [StringLength(10)]
        public virtual string Passwordsalt { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
    }
}
