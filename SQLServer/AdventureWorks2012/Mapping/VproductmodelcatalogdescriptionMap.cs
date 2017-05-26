using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class VproductmodelcatalogdescriptionMap : ClassMapping<Vproductmodelcatalogdescription> {
        
        public VproductmodelcatalogdescriptionMap() {
			Schema("Production");
			Lazy(true);
			Property(x => x.Productmodelid, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Summary);
			Property(x => x.Manufacturer);
			Property(x => x.Copyright, map => map.Length(30));
			Property(x => x.Producturl, map => map.Length(256));
			Property(x => x.Warrantyperiod, map => map.Length(256));
			Property(x => x.Warrantydescription, map => map.Length(256));
			Property(x => x.Noofyears, map => map.Length(256));
			Property(x => x.Maintenancedescription, map => map.Length(256));
			Property(x => x.Wheel, map => map.Length(256));
			Property(x => x.Saddle, map => map.Length(256));
			Property(x => x.Pedal, map => map.Length(256));
			Property(x => x.Bikeframe);
			Property(x => x.Crankset, map => map.Length(256));
			Property(x => x.Pictureangle, map => map.Length(256));
			Property(x => x.Picturesize, map => map.Length(256));
			Property(x => x.Productphotoid, map => map.Length(256));
			Property(x => x.Material, map => map.Length(256));
			Property(x => x.Color, map => map.Length(256));
			Property(x => x.Productline, map => map.Length(256));
			Property(x => x.Style, map => map.Length(256));
			Property(x => x.Riderexperience, map => map.Length(1024));
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
        }
    }
}
