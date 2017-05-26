using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class EmployeeMap : ClassMapping<Employee> {
        
        public EmployeeMap() {
			Schema("HumanResources");
			Lazy(true);
			Id(x => x.Businessentityid, map => map.Generator(Generators.Assigned));
			Property(x => x.Nationalidnumber, map => { map.NotNullable(true); map.Length(15); });
			Property(x => x.Loginid, map => { map.NotNullable(true); map.Length(256); });
			Property(x => x.Organizationnode, map => map.Length(892));
			Property(x => x.Organizationlevel, map => map.Precision(5));
			Property(x => x.Jobtitle, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Birthdate, map => map.NotNullable(true));
			Property(x => x.Maritalstatus, map => { map.NotNullable(true); map.Length(1); });
			Property(x => x.Gender, map => { map.NotNullable(true); map.Length(1); });
			Property(x => x.Hiredate, map => map.NotNullable(true));
			Property(x => x.Salariedflag, map => map.NotNullable(true));
			Property(x => x.Vacationhours, map => { map.NotNullable(true); map.Precision(5); });
			Property(x => x.Sickleavehours, map => { map.NotNullable(true); map.Precision(5); });
			Property(x => x.Currentflag, map => map.NotNullable(true));
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Person, map => 
			{
				map.Column("BusinessEntityID");
				map.PropertyRef("Businessentityid");
				map.Cascade(Cascade.None);
			});

			Bag(x => x.Employeedepartmenthistory, colmap =>  { colmap.Key(x => x.Column("BusinessEntityID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Employeepayhistory, colmap =>  { colmap.Key(x => x.Column("BusinessEntityID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Jobcandidate, colmap =>  { colmap.Key(x => x.Column("BusinessEntityID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
