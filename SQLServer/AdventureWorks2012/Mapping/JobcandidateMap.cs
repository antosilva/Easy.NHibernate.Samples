using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class JobcandidateMap : ClassMapping<Jobcandidate> {
        
        public JobcandidateMap() {
			Schema("HumanResources");
			Lazy(true);
			Id(x => x.Jobcandidateid, map => map.Generator(Generators.Identity));
			Property(x => x.Resume);
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Employee, map => 
			{
				map.Column("BusinessEntityID");
				map.PropertyRef("Businessentityid");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

        }
    }
}
