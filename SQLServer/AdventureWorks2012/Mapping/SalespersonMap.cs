using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class SalespersonMap : ClassMapping<Salesperson> {
        
        public SalespersonMap() {
			Schema("Sales");
			Lazy(true);
			Id(x => x.Businessentityid, map => map.Generator(Generators.Assigned));
			Property(x => x.Salesquota, map => { map.Precision(19); map.Scale(4); });
			Property(x => x.Bonus, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Commissionpct, map => 
			{
				map.NotNullable(true);
				map.Precision(10);
				map.Scale(4);
			});
			Property(x => x.Salesytd, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Saleslastyear, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Employee, map => 
			{
				map.Column("BusinessEntityID");
				map.PropertyRef("Businessentityid");
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Salesterritory, map => 
			{
				map.Column("TerritoryID");
				map.PropertyRef("Territoryid");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			Bag(x => x.Salesorderheader, colmap =>  { colmap.Key(x => x.Column("SalesPersonID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Salespersonquotahistory, colmap =>  { colmap.Key(x => x.Column("BusinessEntityID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Salesterritoryhistory, colmap =>  { colmap.Key(x => x.Column("BusinessEntityID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Store, colmap =>  { colmap.Key(x => x.Column("SalesPersonID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
