using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ScoresMap : ClassMapping<Scores> {
        
        public ScoresMap() {
			Schema("Stats");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Testid, m => m.Column("testid"));
					compId.Property(x => x.Studentid, m => m.Column("studentid"));
				});
			Property(x => x.Score, map => { map.NotNullable(true); map.Precision(3); });
			ManyToOne(x => x.Tests, map => { map.Column("testid"); map.Cascade(Cascade.None); });

        }
    }
}
