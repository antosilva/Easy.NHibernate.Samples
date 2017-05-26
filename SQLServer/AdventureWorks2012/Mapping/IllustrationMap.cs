using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class IllustrationMap : ClassMapping<Illustration> {
        
        public IllustrationMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Illustrationid, map => map.Generator(Generators.Identity));
			Property(x => x.Diagram);
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Productmodelillustration, colmap =>  { colmap.Key(x => x.Column("IllustrationID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
