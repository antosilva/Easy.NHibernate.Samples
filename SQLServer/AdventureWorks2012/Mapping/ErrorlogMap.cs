using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ErrorlogMap : ClassMapping<Errorlog> {
        
        public ErrorlogMap() {
			Schema("dbo");
			Lazy(true);
			Id(x => x.Errorlogid, map => map.Generator(Generators.Identity));
			Property(x => x.Errortime, map => map.NotNullable(true));
			Property(x => x.Username, map => { map.NotNullable(true); map.Length(128); });
			Property(x => x.Errornumber, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Errorseverity, map => map.Precision(10));
			Property(x => x.Errorstate, map => map.Precision(10));
			Property(x => x.Errorprocedure, map => map.Length(126));
			Property(x => x.Errorline, map => map.Precision(10));
			Property(x => x.Errormessage, map => { map.NotNullable(true); map.Length(4000); });
        }
    }
}
