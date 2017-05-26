using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class CurrencyrateMap : ClassMapping<Currencyrate> {
        
        public CurrencyrateMap() {
			Schema("Sales");
			Lazy(true);
			Id(x => x.Currencyrateid, map => map.Generator(Generators.Identity));
			Property(x => x.Currencyratedate, map => map.NotNullable(true));
			Property(x => x.Averagerate, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Endofdayrate, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Fromcurrencycode, map => { map.Column("FromCurrencyCode"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Tocurrencycode, map => { map.Column("ToCurrencyCode"); map.Cascade(Cascade.None); });

			Bag(x => x.Salesorderheader, colmap =>  { colmap.Key(x => x.Column("CurrencyRateID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
