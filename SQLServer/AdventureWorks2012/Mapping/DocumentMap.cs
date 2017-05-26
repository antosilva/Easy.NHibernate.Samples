using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class DocumentMap : ClassMapping<Document> {
        
        public DocumentMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Documentnode, map => map.Generator(Generators.Assigned));
			Property(x => x.Documentlevel, map => map.Precision(5));
			Property(x => x.Title, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Folderflag, map => map.NotNullable(true));
			Property(x => x.Filename, map => { map.NotNullable(true); map.Length(400); });
			Property(x => x.Fileextension, map => { map.NotNullable(true); map.Length(8); });
			Property(x => x.Revision, map => { map.NotNullable(true); map.Length(5); });
			Property(x => x.Changenumber, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Status, map => { map.NotNullable(true); map.Precision(3); });
			Property(x => x.Documentsummary);
			Property(x => x.Document);
			Property(x => x.Rowguid, map => { map.NotNullable(true); map.Unique(true); });
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Employee, map => 
			{
				map.Column("Owner");
				map.PropertyRef("Businessentityid");
				map.Cascade(Cascade.None);
			});

			Bag(x => x.Productdocument, colmap =>  { colmap.Key(x => x.Column("DocumentNode")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
