using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class BusinessentityMap : ClassMapping<Businessentity> {
        
        public BusinessentityMap() {
			Schema("Person");
			Lazy(true);
			Id(x => x.Businessentityid, map => map.Generator(Generators.Identity));
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Businessentityaddress, colmap =>  { colmap.Key(x => x.Column("BusinessEntityID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Businessentitycontact, colmap =>  { colmap.Key(x => x.Column("BusinessEntityID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Person, colmap =>  { colmap.Key(x => x.Column("BusinessEntityID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
