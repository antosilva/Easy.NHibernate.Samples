using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vpersondemographics {
        [Required]
        public virtual int Businessentityid { get; set; }
        public virtual decimal? Totalpurchaseytd { get; set; }
        public virtual DateTime? Datefirstpurchase { get; set; }
        public virtual DateTime? Birthdate { get; set; }
        [StringLength(1)]
        public virtual string Maritalstatus { get; set; }
        [StringLength(30)]
        public virtual string Yearlyincome { get; set; }
        [StringLength(1)]
        public virtual string Gender { get; set; }
        public virtual int? Totalchildren { get; set; }
        public virtual int? Numberchildrenathome { get; set; }
        [StringLength(30)]
        public virtual string Education { get; set; }
        [StringLength(30)]
        public virtual string Occupation { get; set; }
        public virtual bool? Homeownerflag { get; set; }
        public virtual int? Numbercarsowned { get; set; }
    }
}
