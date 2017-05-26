using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Databaselog {
        public virtual int Databaselogid { get; set; }
        [Required]
        public virtual DateTime Posttime { get; set; }
        [Required]
        [StringLength(128)]
        public virtual string Databaseuser { get; set; }
        [Required]
        [StringLength(128)]
        public virtual string Event { get; set; }
        [StringLength(128)]
        public virtual string Schema { get; set; }
        [StringLength(128)]
        public virtual string Object { get; set; }
        [Required]
        public virtual string Tsql { get; set; }
        [Required]
        public virtual string Xmlevent { get; set; }
    }
}
