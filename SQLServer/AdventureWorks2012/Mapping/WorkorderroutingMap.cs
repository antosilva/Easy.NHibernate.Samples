using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class WorkorderroutingMap : ClassMapping<Workorderrouting> {
        
        public WorkorderroutingMap() {
			Schema("Production");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Workorderid, m => m.Column("WorkOrderID"));
					compId.Property(x => x.Productid, m => m.Column("ProductID"));
					compId.Property(x => x.Operationsequence, m => m.Column("OperationSequence"));
				});
			Property(x => x.Scheduledstartdate, map => map.NotNullable(true));
			Property(x => x.Scheduledenddate, map => map.NotNullable(true));
			Property(x => x.Actualstartdate);
			Property(x => x.Actualenddate);
			Property(x => x.Actualresourcehrs, map => { map.Precision(9); map.Scale(4); });
			Property(x => x.Plannedcost, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Actualcost, map => { map.Precision(19); map.Scale(4); });
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Workorder, map => { map.Column("WorkOrderID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Location, map => 
			{
				map.Column("LocationID");
				map.PropertyRef("Locationid");
				map.Cascade(Cascade.None);
			});

        }
    }
}
