using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class WorkorderMap : ClassMapping<Workorder> {
        
        public WorkorderMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Workorderid, map => map.Generator(Generators.Identity));
			Property(x => x.Orderqty, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Stockedqty, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Scrappedqty, map => { map.NotNullable(true); map.Precision(5); });
			Property(x => x.Startdate, map => map.NotNullable(true));
			Property(x => x.Enddate);
			Property(x => x.Duedate, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Product, map => 
			{
				map.Column("ProductID");
				map.PropertyRef("Productid");
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Scrapreason, map => 
			{
				map.Column("ScrapReasonID");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			Bag(x => x.Workorderrouting, colmap =>  { colmap.Key(x => x.Column("WorkOrderID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
