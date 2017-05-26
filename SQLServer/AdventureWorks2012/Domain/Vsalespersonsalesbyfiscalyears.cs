using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vsalespersonsalesbyfiscalyears {
        public virtual int? Salespersonid { get; set; }
        [StringLength(152)]
        public virtual string Fullname { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Jobtitle { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Salesterritory { get; set; }
        public virtual decimal? 2002 { get; set; }
        public virtual decimal? 2003 { get; set; }
        public virtual decimal? 2004 { get; set; }
    }
}
