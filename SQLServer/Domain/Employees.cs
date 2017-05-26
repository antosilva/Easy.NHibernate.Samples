using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Employees {
        public Employees() {
			Employees = new List<Employees>();
        }
        public virtual int Empid { get; set; }
        public virtual Employees EmployeesVal { get; set; }
        [Required]
        [StringLength(20)]
        public virtual string Lastname { get; set; }
        [Required]
        [StringLength(10)]
        public virtual string Firstname { get; set; }
        [Required]
        [StringLength(30)]
        public virtual string Title { get; set; }
        [Required]
        [StringLength(25)]
        public virtual string Titleofcourtesy { get; set; }
        [Required]
        public virtual DateTime Birthdate { get; set; }
        [Required]
        public virtual DateTime Hiredate { get; set; }
        [Required]
        [StringLength(60)]
        public virtual string Address { get; set; }
        [Required]
        [StringLength(15)]
        public virtual string City { get; set; }
        [StringLength(15)]
        public virtual string Region { get; set; }
        [StringLength(10)]
        public virtual string Postalcode { get; set; }
        [Required]
        [StringLength(15)]
        public virtual string Country { get; set; }
        [Required]
        [StringLength(24)]
        public virtual string Phone { get; set; }
        public virtual IList<Employees> Employees { get; set; }
    }
}
