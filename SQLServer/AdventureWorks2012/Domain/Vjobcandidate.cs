using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vjobcandidate {
        [Required]
        public virtual int Jobcandidateid { get; set; }
        public virtual int? Businessentityid { get; set; }
        [StringLength(30)]
        public virtual string Nameprefix { get; set; }
        [StringLength(30)]
        public virtual string Namefirst { get; set; }
        [StringLength(30)]
        public virtual string Namemiddle { get; set; }
        [StringLength(30)]
        public virtual string Namelast { get; set; }
        [StringLength(30)]
        public virtual string Namesuffix { get; set; }
        public virtual string Skills { get; set; }
        [StringLength(30)]
        public virtual string Addrtype { get; set; }
        [StringLength(100)]
        public virtual string Addrloccountryregion { get; set; }
        [StringLength(100)]
        public virtual string Addrlocstate { get; set; }
        [StringLength(100)]
        public virtual string Addrloccity { get; set; }
        [StringLength(20)]
        public virtual string Addrpostalcode { get; set; }
        public virtual string Email { get; set; }
        public virtual string Website { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
    }
}
