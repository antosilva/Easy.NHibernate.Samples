using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class VjobcandidateeducationMap : ClassMapping<Vjobcandidateeducation> {
        
        public VjobcandidateeducationMap() {
			Schema("HumanResources");
			Lazy(true);
			Property(x => x.Jobcandidateid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Edulevel, map => map.Column("Edu.Level"));
			Property(x => x.Edustartdate, map => map.Column("Edu.StartDate"));
			Property(x => x.Eduenddate, map => map.Column("Edu.EndDate"));
			Property(x => x.Edudegree, map => { map.Column("Edu.Degree"); map.Length(50); });
			Property(x => x.Edumajor, map => { map.Column("Edu.Major"); map.Length(50); });
			Property(x => x.Eduminor, map => { map.Column("Edu.Minor"); map.Length(50); });
			Property(x => x.Edugpa, map => { map.Column("Edu.GPA"); map.Length(5); });
			Property(x => x.Edugpascale, map => { map.Column("Edu.GPAScale"); map.Length(5); });
			Property(x => x.Eduschool, map => { map.Column("Edu.School"); map.Length(100); });
			Property(x => x.Eduloccountryregion, map => { map.Column("Edu.Loc.CountryRegion"); map.Length(100); });
			Property(x => x.Edulocstate, map => { map.Column("Edu.Loc.State"); map.Length(100); });
			Property(x => x.Eduloccity, map => { map.Column("Edu.Loc.City"); map.Length(100); });
        }
    }
}
