using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class VjobcandidateMap : ClassMapping<Vjobcandidate> {
        
        public VjobcandidateMap() {
			Schema("HumanResources");
			Lazy(true);
			Property(x => x.Jobcandidateid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Businessentityid, map => map.Precision(10));
			Property(x => x.Nameprefix, map => { map.Column("Name.Prefix"); map.Length(30); });
			Property(x => x.Namefirst, map => { map.Column("Name.First"); map.Length(30); });
			Property(x => x.Namemiddle, map => { map.Column("Name.Middle"); map.Length(30); });
			Property(x => x.Namelast, map => { map.Column("Name.Last"); map.Length(30); });
			Property(x => x.Namesuffix, map => { map.Column("Name.Suffix"); map.Length(30); });
			Property(x => x.Skills);
			Property(x => x.Addrtype, map => { map.Column("Addr.Type"); map.Length(30); });
			Property(x => x.Addrloccountryregion, map => { map.Column("Addr.Loc.CountryRegion"); map.Length(100); });
			Property(x => x.Addrlocstate, map => { map.Column("Addr.Loc.State"); map.Length(100); });
			Property(x => x.Addrloccity, map => { map.Column("Addr.Loc.City"); map.Length(100); });
			Property(x => x.Addrpostalcode, map => { map.Column("Addr.PostalCode"); map.Length(20); });
			Property(x => x.Email);
			Property(x => x.Website);
			Property(x => x.Modifieddate, map => map.NotNullable(true));
        }
    }
}
