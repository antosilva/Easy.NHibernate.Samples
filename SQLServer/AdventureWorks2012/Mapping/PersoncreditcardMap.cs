using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class PersoncreditcardMap : ClassMapping<Personcreditcard> {
        
        public PersoncreditcardMap() {
			Schema("Sales");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Businessentityid, m => m.Column("BusinessEntityID"));
					compId.Property(x => x.Creditcardid, m => m.Column("CreditCardID"));
				});
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Person, map => 
			{
				map.Column("BusinessEntityID");
				map.PropertyRef("Businessentityid");
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Creditcard, map => { map.Column("CreditCardID"); map.Cascade(Cascade.None); });

        }
    }
}
