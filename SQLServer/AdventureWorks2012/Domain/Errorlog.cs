using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Errorlog {
        public virtual int Errorlogid { get; set; }
        [Required]
        public virtual DateTime Errortime { get; set; }
        [Required]
        [StringLength(128)]
        public virtual string Username { get; set; }
        [Required]
        public virtual int Errornumber { get; set; }
        public virtual int? Errorseverity { get; set; }
        public virtual int? Errorstate { get; set; }
        [StringLength(126)]
        public virtual string Errorprocedure { get; set; }
        public virtual int? Errorline { get; set; }
        [Required]
        [StringLength(4000)]
        public virtual string Errormessage { get; set; }
    }
}
