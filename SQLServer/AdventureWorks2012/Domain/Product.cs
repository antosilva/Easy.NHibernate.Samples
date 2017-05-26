using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Product {
        public Product() {
			Billofmaterials = new List<Billofmaterials>();
			Billofmaterials = new List<Billofmaterials>();
			Productcosthistory = new List<Productcosthistory>();
			Productdocument = new List<Productdocument>();
			Productinventory = new List<Productinventory>();
			Productlistpricehistory = new List<Productlistpricehistory>();
			Productproductphoto = new List<Productproductphoto>();
			Productreview = new List<Productreview>();
			Transactionhistory = new List<Transactionhistory>();
			Workorder = new List<Workorder>();
        }
        public virtual int Productid { get; set; }
        public virtual Unitmeasure Unitmeasure { get; set; }
        public virtual Productsubcategory Productsubcategory { get; set; }
        public virtual Productmodel Productmodel { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required]
        [StringLength(25)]
        public virtual string Productnumber { get; set; }
        [Required]
        public virtual bool Makeflag { get; set; }
        [Required]
        public virtual bool Finishedgoodsflag { get; set; }
        [StringLength(15)]
        public virtual string Color { get; set; }
        [Required]
        public virtual short Safetystocklevel { get; set; }
        [Required]
        public virtual short Reorderpoint { get; set; }
        [Required]
        public virtual decimal Standardcost { get; set; }
        [Required]
        public virtual decimal Listprice { get; set; }
        [StringLength(5)]
        public virtual string Size { get; set; }
        public virtual decimal? Weight { get; set; }
        [Required]
        public virtual int Daystomanufacture { get; set; }
        [StringLength(2)]
        public virtual string Productline { get; set; }
        [StringLength(2)]
        public virtual string Class { get; set; }
        [StringLength(2)]
        public virtual string Style { get; set; }
        [Required]
        public virtual DateTime Sellstartdate { get; set; }
        public virtual DateTime? Sellenddate { get; set; }
        public virtual DateTime? Discontinueddate { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Billofmaterials> Billofmaterials { get; set; }
        public virtual IList<Billofmaterials> Billofmaterials { get; set; }
        public virtual IList<Productcosthistory> Productcosthistory { get; set; }
        public virtual IList<Productdocument> Productdocument { get; set; }
        public virtual IList<Productinventory> Productinventory { get; set; }
        public virtual IList<Productlistpricehistory> Productlistpricehistory { get; set; }
        public virtual IList<Productproductphoto> Productproductphoto { get; set; }
        public virtual IList<Productreview> Productreview { get; set; }
        public virtual IList<Transactionhistory> Transactionhistory { get; set; }
        public virtual IList<Workorder> Workorder { get; set; }
    }
}
