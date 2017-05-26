using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class UnitmeasureMap : ClassMapping<Unitmeasure> {
        
        public UnitmeasureMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Unitmeasurecode, map => map.Generator(Generators.Assigned));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			Bag(x => x.Billofmaterials, colmap =>  { colmap.Key(x => x.Column("UnitMeasureCode")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Product, colmap =>  { colmap.Key(x => x.Column("SizeUnitMeasureCode")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Product, colmap =>  { colmap.Key(x => x.Column("WeightUnitMeasureCode")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
