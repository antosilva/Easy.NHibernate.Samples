using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class BusinessentityaddressMap : ClassMapping<Businessentityaddress> {
        
        public BusinessentityaddressMap() {
			Schema("Person");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Businessentityid, m => m.Column("BusinessEntityID"));
					compId.Property(x => x.Addressid, m => m.Column("AddressID"));
					compId.Property(x => x.Addresstypeid, m => m.Column("AddressTypeID"));
				});
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Businessentity, map => { map.Column("BusinessEntityID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Address, map => { map.Column("AddressID"); map.Cascade(Cascade.None); });

			ManyToOne(x => x.Addresstype, map => { map.Column("AddressTypeID"); map.Cascade(Cascade.None); });

        }
    }
}
