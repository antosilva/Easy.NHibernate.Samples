using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vjobcandidateeducation {
        [Required]
        public virtual int Jobcandidateid { get; set; }
        public virtual string Edulevel { get; set; }
        public virtual DateTime? Edustartdate { get; set; }
        public virtual DateTime? Eduenddate { get; set; }
        [StringLength(50)]
        public virtual string Edudegree { get; set; }
        [StringLength(50)]
        public virtual string Edumajor { get; set; }
        [StringLength(50)]
        public virtual string Eduminor { get; set; }
        [StringLength(5)]
        public virtual string Edugpa { get; set; }
        [StringLength(5)]
        public virtual string Edugpascale { get; set; }
        [StringLength(100)]
        public virtual string Eduschool { get; set; }
        [StringLength(100)]
        public virtual string Eduloccountryregion { get; set; }
        [StringLength(100)]
        public virtual string Edulocstate { get; set; }
        [StringLength(100)]
        public virtual string Eduloccity { get; set; }
    }
}
