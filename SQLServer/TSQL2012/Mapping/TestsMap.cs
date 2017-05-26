using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class TestsMap : ClassMapping<Tests> {
        
        public TestsMap() {
			Schema("Stats");
			Lazy(true);
			Id(x => x.Testid, map => map.Generator(Generators.Assigned));
			Bag(x => x.Scores, colmap =>  { colmap.Key(x => x.Column("testid")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
