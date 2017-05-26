using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class DepartmentMap : ClassMapping<Department> {
        
        public DepartmentMap() {
			Schema("HumanResources");
			Lazy(true);
			Id(x => x.Departmentid, map => map.Generator(Generators.Identity));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Groupname, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Employeedepartmenthistory, colmap =>  { colmap.Key(x => x.Column("DepartmentID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
