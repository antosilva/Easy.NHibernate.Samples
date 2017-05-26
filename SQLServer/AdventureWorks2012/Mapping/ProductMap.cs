using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Sample.CustomerService.Domain;


namespace Sample.CustomerService.Maps {
    
    
    public class ProductMap : ClassMapping<Product> {
        
        public ProductMap() {
			Schema("Production");
			Lazy(true);
			Id(x => x.Productid, map => map.Generator(Generators.Identity));
			Property(x => x.Name, map => { map.NotNullable(true); map.Length(50); });
			Property(x => x.Productnumber, map => { map.NotNullable(true); map.Length(25); });
			Property(x => x.Makeflag, map => map.NotNullable(true));
			Property(x => x.Finishedgoodsflag, map => map.NotNullable(true));
			Property(x => x.Color, map => map.Length(15));
			Property(x => x.Safetystocklevel, map => { map.NotNullable(true); map.Precision(5); });
			Property(x => x.Reorderpoint, map => { map.NotNullable(true); map.Precision(5); });
			Property(x => x.Standardcost, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Listprice, map => 
			{
				map.NotNullable(true);
				map.Precision(19);
				map.Scale(4);
			});
			Property(x => x.Size, map => map.Length(5));
			Property(x => x.Weight, map => { map.Precision(8); map.Scale(2); });
			Property(x => x.Daystomanufacture, map => { map.NotNullable(true); map.Precision(10); });
			Property(x => x.Productline, map => map.Length(2));
			Property(x => x.Class, map => map.Length(2));
			Property(x => x.Style, map => map.Length(2));
			Property(x => x.Sellstartdate, map => map.NotNullable(true));
			Property(x => x.Sellenddate);
			Property(x => x.Discontinueddate);
			Property(x => x.Rowguid, map => map.NotNullable(true));
			Property(x => x.Modifieddate, map => map.NotNullable(true));
			ManyToOne(x => x.Sizeunitmeasurecode, map => 
			{
				map.Column("SizeUnitMeasureCode");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Weightunitmeasurecode, map => 
			{
				map.Column("WeightUnitMeasureCode");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Productsubcategory, map => 
			{
				map.Column("ProductSubcategoryID");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			ManyToOne(x => x.Productmodel, map => 
			{
				map.Column("ProductModelID");
				map.NotNullable(true);
				map.Cascade(Cascade.None);
			});

			Bag(x => x.Billofmaterials, colmap =>  { colmap.Key(x => x.Column("ComponentID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Billofmaterials, colmap =>  { colmap.Key(x => x.Column("ProductAssemblyID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Productcosthistory, colmap =>  { colmap.Key(x => x.Column("ProductID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Productdocument, colmap =>  { colmap.Key(x => x.Column("ProductID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Productinventory, colmap =>  { colmap.Key(x => x.Column("ProductID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Productlistpricehistory, colmap =>  { colmap.Key(x => x.Column("ProductID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Productproductphoto, colmap =>  { colmap.Key(x => x.Column("ProductID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Productreview, colmap =>  { colmap.Key(x => x.Column("ProductID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Transactionhistory, colmap =>  { colmap.Key(x => x.Column("ProductID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.Workorder, colmap =>  { colmap.Key(x => x.Column("ProductID")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
