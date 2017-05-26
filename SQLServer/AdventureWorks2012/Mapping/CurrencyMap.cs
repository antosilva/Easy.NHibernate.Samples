using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class CurrencyMap : ClassMapping<Currency> {
        
        public CurrencyMap() {
			Schema("Sales");
			Lazy(true);
			Id(x => x.Currencycode, map => map.Generator(Generators.Assigned));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Countryregioncurrency, colmap =>  { colmap.Key(x => x.Column("CurrencyCode")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Currencyrate, colmap =>  { colmap.Key(x => x.Column("FromCurrencyCode")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Currencyrate, colmap =>  { colmap.Key(x => x.Column("ToCurrencyCode")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
