using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class VsalespersonMap : ClassMapping<Vsalesperson> {
        
        public VsalespersonMap() {
			Schema("Sales");
			Lazy(true);
			Property(x => x.Businessentityid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Title, map => map.Length(8));
			Property(x => x.Firstname, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Middlename, map => map.Length(50));
			Property(x => x.Lastname, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Suffix, map => map.Length(10));
			Property(x => x.Jobtitle, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Phonenumber, map => map.Length(25));
			Property(x => x.Phonenumbertype, map => map.Length(50));
			Property(x => x.Emailaddress, map => map.Length(50));
			Property(x => x.Emailpromotion, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Addressline1, map => { map.NotNullable(true); map.Length(60); });
			Property(x => x.Addressline2, map => map.Length(60));
			Property(x => x.City, map => { map.NotNullable(true); map.Length(30); });
			Property(x => x.Stateprovincename, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Postalcode, map => { map.NotNullable(true); map.Length(15); });
			Property(x => x.Countryregionname, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Territoryname, map => map.Length(50));
			Property(x => x.Territorygroup, map => map.Length(50));
			Property(x => x.Salesquota, map => { map.Precision(19); map.Scale(4); });
			Property(x => x.Salesytd, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Saleslastyear, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
        }
    }
}
