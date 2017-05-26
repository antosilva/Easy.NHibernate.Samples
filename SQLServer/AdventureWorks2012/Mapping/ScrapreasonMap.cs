using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ScrapreasonMap : ClassMapping<Scrapreason> {
        
        public ScrapreasonMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Scrapreasonid, map => map.Generator(Generators.Identity));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Workorder, colmap =>  { colmap.Key(x => x.Column("ScrapReasonID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
