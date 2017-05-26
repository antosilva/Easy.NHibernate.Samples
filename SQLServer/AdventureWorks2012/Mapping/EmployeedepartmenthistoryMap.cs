using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class EmployeedepartmenthistoryMap : ClassMapping<Employeedepartmenthistory> {
        
        public EmployeedepartmenthistoryMap() {
			Schema("HumanResources");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Businessentityid, m => m.Column("BusinessEntityID"));
					compId.Property(x => x.Departmentid, m => m.Column("DepartmentID"));
					compId.Property(x => x.Shiftid, m => m.Column("ShiftID"));
					compId.Property(x => x.Startdate, m => m.Column("StartDate"));
				});
			Property(x => x.Enddate);
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Employee, map => 
			{
				map.Column("BusinessEntityID");
				map.PropertyRef("Businessentityid");
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Department, map => { map.Column("DepartmentID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Shift, map => { map.Column("ShiftID"); map.Cascade(Cascade.None); });

        }
    }
}
