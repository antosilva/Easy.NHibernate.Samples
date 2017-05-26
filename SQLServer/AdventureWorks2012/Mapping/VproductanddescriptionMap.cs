using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class VproductanddescriptionMap : ClassMapping<Vproductanddescription> {
        
        public VproductanddescriptionMap() {
			Schema("Production");
			Lazy(true);
			Property(x => x.Productid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Productmodel, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Cultureid, map => { map.NotNullable(true); map.Length(6); });
			Property(x => x.Description, map => { map.NotNullable(true); map.Length(400); });
        }
    }
}
