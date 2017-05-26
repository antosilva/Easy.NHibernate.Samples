using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vjobcandidateemployment {
        [Required]
        public virtual int Jobcandidateid { get; set; }
        public virtual DateTime? Empstartdate { get; set; }
        public virtual DateTime? Empenddate { get; set; }
        [StringLength(100)]
        public virtual string Emporgname { get; set; }
        [StringLength(100)]
        public virtual string Empjobtitle { get; set; }
        public virtual string Empresponsibility { get; set; }
        public virtual string Empfunctioncategory { get; set; }
        public virtual string Empindustrycategory { get; set; }
        public virtual string Emploccountryregion { get; set; }
        public virtual string Emplocstate { get; set; }
        public virtual string Emploccity { get; set; }
    }
}
