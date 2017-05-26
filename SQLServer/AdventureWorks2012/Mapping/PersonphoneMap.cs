using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class PersonphoneMap : ClassMapping<Personphone> {
        
        public PersonphoneMap() {
			Schema("Person");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Businessentityid, m => m.Column("BusinessEntityID"));
					compId.Property(x => x.Phonenumber, m => m.Column("PhoneNumber"));
					compId.Property(x => x.Phonenumbertypeid, m => m.Column("PhoneNumberTypeID"));
				});
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Person, map => 
			{
				map.Column("BusinessEntityID");
				map.PropertyRef("Businessentityid");
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Phonenumbertype, map => { map.Column("PhoneNumberTypeID"); map.Cascade(Cascade.None); });

        }
    }
}
