using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class SalesorderheadersalesreasonMap : ClassMapping<Salesorderheadersalesreason> {
        
        public SalesorderheadersalesreasonMap() {
			Schema("Sales");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Salesorderid, m => m.Column("SalesOrderID"));
					compId.Property(x => x.Salesreasonid, m => m.Column("SalesReasonID"));
				});
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Salesorderheader, map => { map.Column("SalesOrderID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Salesreason, map => { map.Column("SalesReasonID"); map.Cascade(Cascade.None); });

        }
    }
}
