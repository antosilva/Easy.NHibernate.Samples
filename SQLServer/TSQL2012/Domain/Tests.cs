using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Tests {
        public Tests() {
			Scores = new List<Scores>();
        }
        public virtual string Testid { get; set; }
        public virtual IList<Scores> Scores { get; set; }
    }
}
