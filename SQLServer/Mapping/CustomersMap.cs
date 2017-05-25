using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class CustomersMap : ClassMapping<Customers> {
        
        public CustomersMap() {
			Schema("Sales");
			Lazy(true);
			Id(x => x.Custid, map => map.Generator(Generators.Identity));
			Property(x => x.Companyname, map => { map.NotNullable(true); map.Length(40); });
			Property(x => x.Contactname, map => { map.NotNullable(true); map.Length(30); });
			Property(x => x.Contacttitle, map => { map.NotNullable(true); map.Length(30); });
			Property(x => x.Address, map => { map.NotNullable(true); map.Length(60); });
			Property(x => x.City, map => { map.NotNullable(true); map.Length(15); });
			Property(x => x.Region, map => map.Length(15));
			Property(x => x.Postalcode, map => map.Length(10));
			Property(x => x.Country, map => { map.NotNullable(true); map.Length(15); });
			Property(x => x.Phone, map => { map.NotNullable(true); map.Length(24); });
			Property(x => x.Fax, map => map.Length(24));
			Bag(x => x.Orders, colmap =>  { colmap.Key(x => x.Column("custid")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
