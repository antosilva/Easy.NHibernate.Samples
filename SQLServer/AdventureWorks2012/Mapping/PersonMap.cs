using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class PersonMap : ClassMapping<Person> {
        
        public PersonMap() {
			Schema("Person");
			Lazy(true);
			Id(x => x.Businessentityid, map => map.Generator(Generators.Assigned));
			Property(x => x.Persontype, map => { map.NotNullable(true); map.Length(2); });
			Property(x => x.Namestyle, map => map.NotNullable(true));
			Property(x => x.Title, map => map.Length(8));
			Property(x => x.Firstname, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Middlename, map => map.Length(50));
			Property(x => x.Lastname, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Suffix, map => map.Length(10));
			Property(x => x.Emailpromotion, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Additionalcontactinfo);
			Property(x => x.Demographics);
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Businessentity, map => { map.Column("BusinessEntityID"); map.Cascade(Cascade.None); });

			Bag(x => x.Businessentitycontact, colmap =>  { colmap.Key(x => x.Column("PersonID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Emailaddress, colmap =>  { colmap.Key(x => x.Column("BusinessEntityID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Password, colmap =>  { colmap.Key(x => x.Column("BusinessEntityID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Personphone, colmap =>  { colmap.Key(x => x.Column("BusinessEntityID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
