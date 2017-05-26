using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Jobcandidate {
        public virtual int Jobcandidateid { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual string Resume { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
    }
}
