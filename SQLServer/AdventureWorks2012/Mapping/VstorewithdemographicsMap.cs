using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class VstorewithdemographicsMap : ClassMapping<Vstorewithdemographics> {
        
        public VstorewithdemographicsMap() {
			Schema("Sales");
			Lazy(true);
			Property(x => x.Businessentityid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Annualsales, map => { map.Precision(19); map.Scale(4); });
			Property(x => x.Annualrevenue, map => { map.Precision(19); map.Scale(4); });
			Property(x => x.Bankname, map => map.Length(50));
			Property(x => x.Businesstype, map => map.Length(5));
			Property(x => x.Yearopened, map => map.Precision(10));
			Property(x => x.Specialty, map => map.Length(50));
			Property(x => x.Squarefeet, map => map.Precision(10));
			Property(x => x.Brands, map => map.Length(30));
			Property(x => x.Internet, map => map.Length(30));
			Property(x => x.Numberemployees, map => map.Precision(10));
        }
    }
}
