using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class BillofmaterialsMap : ClassMapping<Billofmaterials> {
        
        public BillofmaterialsMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Billofmaterialsid, map => map.Generator(Generators.Identity));
			Property(x => x.Startdate, map => map.NotNullable(true));
			Property(x => x.Enddate);
			Property(x => x.Bomlevel, map => { map.NotNullable(true); map.Precision(5); });
			Property(x => x.Perassemblyqty, map => 
			{
				map.NotNullable(true);
				map.Precision(8);
				map.Scale(2);
			});
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Productassemblyid, map => 
			{
				map.Column("ProductAssemblyID");
				map.PropertyRef("Productid");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Componentid, map => 
			{
				map.Column("ComponentID");
				map.PropertyRef("Productid");
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Unitmeasure, map => { map.Column("UnitMeasureCode"); map.Cascade(Cascade.None); });

        }
    }
}
