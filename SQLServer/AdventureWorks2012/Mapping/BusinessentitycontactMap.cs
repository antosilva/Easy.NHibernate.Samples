using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class BusinessentitycontactMap : ClassMapping<Businessentitycontact> {
        
        public BusinessentitycontactMap() {
			Schema("Person");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Businessentityid, m => m.Column("BusinessEntityID"));
					compId.Property(x => x.Personid, m => m.Column("PersonID"));
					compId.Property(x => x.Contacttypeid, m => m.Column("ContactTypeID"));
				});
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Businessentity, map => { map.Column("BusinessEntityID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Person, map => 
			{
				map.Column("PersonID");
				map.PropertyRef("Businessentityid");
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Contacttype, map => { map.Column("ContactTypeID"); map.Cascade(Cascade.None); });

        }
    }
}
