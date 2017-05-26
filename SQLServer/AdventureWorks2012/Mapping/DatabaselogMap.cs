using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class DatabaselogMap : ClassMapping<Databaselog> {
        
        public DatabaselogMap() {
			Schema("dbo");
			Lazy(true);
			Id(x => x.Databaselogid, map => map.Generator(Generators.Identity));
			Property(x => x.Posttime, map => map.NotNullable(true));
			Property(x => x.Databaseuser, map => { map.NotNullable(true); map.Length(128); });
			Property(x => x.Event, map => { map.NotNullable(true); map.Length(128); });
			Property(x => x.Schema, map => map.Length(128));
			Property(x => x.Object, map => map.Length(128));
			Property(x => x.Tsql, map => map.NotNullable(true));
			Property(x => x.Xmlevent, map => map.NotNullable(true));
        }
    }
}
