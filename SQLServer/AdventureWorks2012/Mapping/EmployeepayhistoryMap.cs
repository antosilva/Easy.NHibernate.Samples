using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class EmployeepayhistoryMap : ClassMapping<Employeepayhistory> {
        
        public EmployeepayhistoryMap() {
			Schema("HumanResources");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Businessentityid, m => m.Column("BusinessEntityID"));
					compId.Property(x => x.Ratechangedate, m => m.Column("RateChangeDate"));
				});
			Property(x => x.Rate, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Payfrequency, map => { map.NotNullable(true); map.Precision(3); });
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Employee, map => 
			{
				map.Column("BusinessEntityID");
				map.PropertyRef("Businessentityid");
				map.Cascade(Cascade.None);
			});

        }
    }
}
