using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ShiftMap : ClassMapping<Shift> {
        
        public ShiftMap() {
			Schema("HumanResources");
			Lazy(true);
			Id(x => x.Shiftid, map => map.Generator(Generators.Identity));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Starttime, map => map.NotNullable(true));
			Property(x => x.Endtime, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Employeedepartmenthistory, colmap =>  { colmap.Key(x => x.Column("ShiftID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
