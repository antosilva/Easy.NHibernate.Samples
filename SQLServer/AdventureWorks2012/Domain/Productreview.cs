using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Productreview {
        public virtual int Productreviewid { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Reviewername { get; set; }
        [Required]
        public virtual DateTime Reviewdate { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Emailaddress { get; set; }
        [Required]
        public virtual int Rating { get; set; }
        [StringLength(3850)]
        public virtual string Comments { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
    }
}
