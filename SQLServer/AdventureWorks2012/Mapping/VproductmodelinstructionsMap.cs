using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class VproductmodelinstructionsMap : ClassMapping<Vproductmodelinstructions> {
        
        public VproductmodelinstructionsMap() {
			Schema("Production");
			Lazy(true);
			Property(x => x.Productmodelid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Instructions);
			Property(x => x.Locationid, map => map.Precision(10));
			Property(x => x.Setuphours, map => { map.Precision(9); map.Scale(4); });
			Property(x => x.Machinehours, map => { map.Precision(9); map.Scale(4); });
			Property(x => x.Laborhours, map => { map.Precision(9); map.Scale(4); });
			Property(x => x.Lotsize, map => map.Precision(10));
			Property(x => x.Step, map => map.Length(1024));
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
        }
    }
}
