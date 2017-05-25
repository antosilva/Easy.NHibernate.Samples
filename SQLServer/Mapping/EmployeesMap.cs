using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class EmployeesMap : ClassMapping<Employees> {
        
        public EmployeesMap() {
			Schema("HR");
			Lazy(true);
			Id(x => x.Empid, map => map.Generator(Generators.Identity));
			Property(x => x.Lastname, map => { map.NotNullable(true); map.Length(20); });
			Property(x => x.Firstname, map => { map.NotNullable(true); map.Length(10); });
			Property(x => x.Title, map => { map.NotNullable(true); map.Length(30); });
			Property(x => x.Titleofcourtesy, map => { map.NotNullable(true); map.Length(25); });
			Property(x => x.Birthdate, map => map.NotNullable(true));
			Property(x => x.Hiredate, map => map.NotNullable(true));
			Property(x => x.Address, map => { map.NotNullable(true); map.Length(60); });
			Property(x => x.City, map => { map.NotNullable(true); map.Length(15); });
			Property(x => x.Region, map => map.Length(15));
			Property(x => x.Postalcode, map => map.Length(10));
			Property(x => x.Country, map => { map.NotNullable(true); map.Length(15); });
			Property(x => x.Phone, map => { map.NotNullable(true); map.Length(24); });
			ManyToOne(x => x.Employees, map => 
			{
				map.Column("mgrid");
				map.PropertyRef("Empid");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			Bag(x => x.Employees, colmap =>  { colmap.Key(x => x.Column("mgrid")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
