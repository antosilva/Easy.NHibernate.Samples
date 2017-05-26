using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class VpersondemographicsMap : ClassMapping<Vpersondemographics> {
        
        public VpersondemographicsMap() {
			Schema("Sales");
			Lazy(true);
			Property(x => x.Businessentityid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Totalpurchaseytd, map => { map.Precision(19); map.Scale(4); });
			Property(x => x.Datefirstpurchase);
			Property(x => x.Birthdate);
			Property(x => x.Maritalstatus, map => map.Length(1));
			Property(x => x.Yearlyincome, map => map.Length(30));
			Property(x => x.Gender, map => map.Length(1));
			Property(x => x.Totalchildren, map => map.Precision(10));
			Property(x => x.Numberchildrenathome, map => map.Precision(10));
			Property(x => x.Education, map => map.Length(30));
			Property(x => x.Occupation, map => map.Length(30));
			Property(x => x.Homeownerflag);
			Property(x => x.Numbercarsowned, map => map.Precision(10));
        }
    }
}
