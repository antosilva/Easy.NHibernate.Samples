using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class VjobcandidateemploymentMap : ClassMapping<Vjobcandidateemployment> {
        
        public VjobcandidateemploymentMap() {
			Schema("HumanResources");
			Lazy(true);
			Property(x => x.Jobcandidateid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Empstartdate, map => map.Column("Emp.StartDate"));
			Property(x => x.Empenddate, map => map.Column("Emp.EndDate"));
			Property(x => x.Emporgname, map => { map.Column("Emp.OrgName"); map.Length(100); });
			Property(x => x.Empjobtitle, map => { map.Column("Emp.JobTitle"); map.Length(100); });
			Property(x => x.Empresponsibility, map => map.Column("Emp.Responsibility"));
			Property(x => x.Empfunctioncategory, map => map.Column("Emp.FunctionCategory"));
			Property(x => x.Empindustrycategory, map => map.Column("Emp.IndustryCategory"));
			Property(x => x.Emploccountryregion, map => map.Column("Emp.Loc.CountryRegion"));
			Property(x => x.Emplocstate, map => map.Column("Emp.Loc.State"));
			Property(x => x.Emploccity, map => map.Column("Emp.Loc.City"));
        }
    }
}
