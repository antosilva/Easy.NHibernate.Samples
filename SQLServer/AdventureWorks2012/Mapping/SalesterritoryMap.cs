using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class SalesterritoryMap : ClassMapping<Salesterritory> {
        
        public SalesterritoryMap() {
			Schema("Sales");
			Lazy(true);
			Id(x => x.Territoryid, map => map.Generator(Generators.Identity));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Group, map => { map.NotNullable(true); map.Length(50); });
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
			Property(x => x.Costytd, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Costlastyear, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Countryregion, map => { map.Column("CountryRegionCode"); map.Cascade(Cascade.None); });

			Bag(x => x.Customer, colmap =>  { colmap.Key(x => x.Column("TerritoryID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Salesorderheader, colmap =>  { colmap.Key(x => x.Column("TerritoryID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Salesperson, colmap =>  { colmap.Key(x => x.Column("TerritoryID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Salesterritoryhistory, colmap =>  { colmap.Key(x => x.Column("TerritoryID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
