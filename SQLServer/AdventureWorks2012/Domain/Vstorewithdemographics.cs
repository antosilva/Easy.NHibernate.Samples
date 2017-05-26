using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vstorewithdemographics {
        [Required]
        public virtual int Businessentityid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        public virtual decimal? Annualsales { get; set; }
        public virtual decimal? Annualrevenue { get; set; }
        [StringLength(50)]
        public virtual string Bankname { get; set; }
        [StringLength(5)]
        public virtual string Businesstype { get; set; }
        public virtual int? Yearopened { get; set; }
        [StringLength(50)]
        public virtual string Specialty { get; set; }
        public virtual int? Squarefeet { get; set; }
        [StringLength(30)]
        public virtual string Brands { get; set; }
        [StringLength(30)]
        public virtual string Internet { get; set; }
        public virtual int? Numberemployees { get; set; }
    }
}
