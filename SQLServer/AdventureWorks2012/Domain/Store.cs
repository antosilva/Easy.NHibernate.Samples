using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Store {
        public Store() {
			Customer = new List<Customer>();
        }
        public virtual int Businessentityid { get; set; }
        public virtual Businessentity Businessentity { get; set; }
        public virtual Salesperson Salesperson { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        public virtual string Demographics { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Customer> Customer { get; set; }
    }
}
