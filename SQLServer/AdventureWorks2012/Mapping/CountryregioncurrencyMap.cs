using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class CountryregioncurrencyMap : ClassMapping<Countryregioncurrency> {
        
        public CountryregioncurrencyMap() {
			Schema("Sales");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Countryregioncode, m => m.Column("CountryRegionCode"));
					compId.Property(x => x.Currencycode, m => m.Column("CurrencyCode"));
				});
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Countryregion, map => { map.Column("CountryRegionCode"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Currency, map => { map.Column("CurrencyCode"); map.Cascade(Cascade.None); });

        }
    }
}
