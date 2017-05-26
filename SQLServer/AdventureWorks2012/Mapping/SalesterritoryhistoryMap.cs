using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class SalesterritoryhistoryMap : ClassMapping<Salesterritoryhistory> {
        
        public SalesterritoryhistoryMap() {
			Schema("Sales");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Businessentityid, m => m.Column("BusinessEntityID"));
					compId.Property(x => x.Territoryid, m => m.Column("TerritoryID"));
					compId.Property(x => x.Startdate, m => m.Column("StartDate"));
				});
			Property(x => x.Enddate);
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Salesperson, map => { map.Column("BusinessEntityID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Salesterritory, map => 
			{
				map.Column("TerritoryID");
				map.PropertyRef("Territoryid");
				map.Cascade(Cascade.None);
			});

        }
    }
}
