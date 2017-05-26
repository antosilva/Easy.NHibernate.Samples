using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class CreditcardMap : ClassMapping<Creditcard> {
        
        public CreditcardMap() {
			Schema("Sales");
			Lazy(true);
			Id(x => x.Creditcardid, map => map.Generator(Generators.Identity));
			Property(x => x.Cardtype, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Cardnumber, map => { map.NotNullable(true); map.Length(25); });
			Property(x => x.Expmonth, map => { map.NotNullable(true); map.Precision(3); });
			Property(x => x.Expyear, map => { map.NotNullable(true); map.Precision(5); });
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Personcreditcard, colmap =>  { colmap.Key(x => x.Column("CreditCardID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Salesorderheader, colmap =>  { colmap.Key(x => x.Column("CreditCardID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
