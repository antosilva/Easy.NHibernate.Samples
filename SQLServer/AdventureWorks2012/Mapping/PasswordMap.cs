using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class PasswordMap : ClassMapping<Password> {
        
        public PasswordMap() {
			Schema("Person");
			Lazy(true);
			Id(x => x.Businessentityid, map => map.Generator(Generators.Assigned));
			Property(x => x.Passwordhash, map => { map.NotNullable(true); map.Length(128); });
			Property(x => x.Passwordsalt, map => { map.NotNullable(true); map.Length(10); });
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Person, map => 
			{
				map.Column("BusinessEntityID");
				map.PropertyRef("Businessentityid");
				map.Cascade(Cascade.None);
			});

        }
    }
}
