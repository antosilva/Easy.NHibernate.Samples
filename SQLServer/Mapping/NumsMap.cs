using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class NumsMap : ClassMapping<Nums> {
        
        public NumsMap() {
			Schema("dbo");
			Lazy(true);
			Id(x => x.N, map => map.Generator(Generators.Assigned));
        }
    }
}
