using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class SalesreasonMap : ClassMapping<Salesreason> {
        
        public SalesreasonMap() {
			Schema("Sales");
			Lazy(true);
			Id(x => x.Salesreasonid, map => map.Generator(Generators.Identity));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Reasontype, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Salesorderheadersalesreason, colmap =>  { colmap.Key(x => x.Column("SalesReasonID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
