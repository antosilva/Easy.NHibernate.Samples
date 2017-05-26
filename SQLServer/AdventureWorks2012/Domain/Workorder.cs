using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Workorder {
        public Workorder() {
			Workorderrouting = new List<Workorderrouting>();
        }
        public virtual int Workorderid { get; set; }
        public virtual Product Product { get; set; }
        public virtual Scrapreason Scrapreason { get; set; }
        [Required]
        public virtual int Orderqty { get; set; }
        [Required]
        public virtual int Stockedqty { get; set; }
        [Required]
        public virtual short Scrappedqty { get; set; }
        [Required]
        public virtual DateTime Startdate { get; set; }
        public virtual DateTime? Enddate { get; set; }
        [Required]
        public virtual DateTime Duedate { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Workorderrouting> Workorderrouting { get; set; }
    }
}
