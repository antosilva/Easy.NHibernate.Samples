using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Sample.CustomerService.Domain {
    
    public class Employees {
        public Employees() {
			Employees = new List<Employees>();
        }
        public virtual int Empid { get; set; }
        public virtual Employees EmployeesVal { get; set; }
        [NotNullNotEmpty]
        [Length(20)]
        public virtual string Lastname { get; set; }
        [NotNullNotEmpty]
        [Length(10)]
        public virtual string Firstname { get; set; }
        [NotNullNotEmpty]
        [Length(30)]
        public virtual string Title { get; set; }
        [NotNullNotEmpty]
        [Length(25)]
        public virtual string Titleofcourtesy { get; set; }
        [NotNullNotEmpty]
        public virtual DateTime Birthdate { get; set; }
        [NotNullNotEmpty]
        public virtual DateTime Hiredate { get; set; }
        [NotNullNotEmpty]
        [Length(60)]
        public virtual string Address { get; set; }
        [NotNullNotEmpty]
        [Length(15)]
        public virtual string City { get; set; }
        [Length(15)]
        public virtual string Region { get; set; }
        [Length(10)]
        public virtual string Postalcode { get; set; }
        [NotNullNotEmpty]
        [Length(15)]
        public virtual string Country { get; set; }
        [NotNullNotEmpty]
        [Length(24)]
        public virtual string Phone { get; set; }
        public virtual IList<Employees> Employees { get; set; }
    }
}
