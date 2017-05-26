using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class EmailaddressMap : ClassMapping<Emailaddress> {
        
        public EmailaddressMap() {
			Schema("Person");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Businessentityid, m => m.Column("BusinessEntityID"));
					compId.Property(x => x.Emailaddressid, m => m.Column("EmailAddressID"));
				});
			Property(x => x.Emailaddress, map => map.Length(50));
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
