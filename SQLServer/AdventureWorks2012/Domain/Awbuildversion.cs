using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Awbuildversion {
        public virtual byte Systeminformationid { get; set; }
        [Required]
        [StringLength(25)]
        public virtual string DatabaseVersion { get; set; }
        [Required]
        public virtual DateTime Versiondate { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
    }
}
