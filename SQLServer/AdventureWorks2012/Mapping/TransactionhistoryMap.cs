using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class TransactionhistoryMap : ClassMapping<Transactionhistory> {
        
        public TransactionhistoryMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Transactionid, map => map.Generator(Generators.Identity));
			Property(x => x.Referenceorderid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Referenceorderlineid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Transactiondate, map => map.NotNullable(true));
			Property(x => x.Transactiontype, map => { map.NotNullable(true); map.Length(1); });
			Property(x => x.Quantity, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Actualcost, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Product, map => 
			{
				map.Column("ProductID");
				map.PropertyRef("Productid");
				map.Cascade(Cascade.None);
			});

        }
    }
}
