using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class AwbuildversionMap : ClassMapping<Awbuildversion> {
        
        public AwbuildversionMap() {
			Schema("dbo");
			Lazy(true);
			Id(x => x.Systeminformationid, map => map.Generator(Generators.Identity));
			Property(x => x.DatabaseVersion, map => 
			{
				map.Column("Database Version");
				map.NotNullable(true);
				map.Length(25);
			});
			Property(x => x.Versiondate, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
        }
    }
}
