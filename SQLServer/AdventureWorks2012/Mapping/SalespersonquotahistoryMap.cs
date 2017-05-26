using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class SalespersonquotahistoryMap : ClassMapping<Salespersonquotahistory> {
        
        public SalespersonquotahistoryMap() {
			Schema("Sales");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Businessentityid, m => m.Column("BusinessEntityID"));
					compId.Property(x => x.Quotadate, m => m.Column("QuotaDate"));
				});
			Property(x => x.Salesquota, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Salesperson, map => { map.Column("BusinessEntityID"); map.Cascade(Cascade.None); });

        }
    }
}
