using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Vproductmodelcatalogdescription {
        [Required]
        public virtual int Productmodelid { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }
        public virtual string Summary { get; set; }
        public virtual string Manufacturer { get; set; }
        [StringLength(30)]
        public virtual string Copyright { get; set; }
        [StringLength(256)]
        public virtual string Producturl { get; set; }
        [StringLength(256)]
        public virtual string Warrantyperiod { get; set; }
        [StringLength(256)]
        public virtual string Warrantydescription { get; set; }
        [StringLength(256)]
        public virtual string Noofyears { get; set; }
        [StringLength(256)]
        public virtual string Maintenancedescription { get; set; }
        [StringLength(256)]
        public virtual string Wheel { get; set; }
        [StringLength(256)]
        public virtual string Saddle { get; set; }
        [StringLength(256)]
        public virtual string Pedal { get; set; }
        public virtual string Bikeframe { get; set; }
        [StringLength(256)]
        public virtual string Crankset { get; set; }
        [StringLength(256)]
        public virtual string Pictureangle { get; set; }
        [StringLength(256)]
        public virtual string Picturesize { get; set; }
        [StringLength(256)]
        public virtual string Productphotoid { get; set; }
        [StringLength(256)]
        public virtual string Material { get; set; }
        [StringLength(256)]
        public virtual string Color { get; set; }
        [StringLength(256)]
        public virtual string Productline { get; set; }
        [StringLength(256)]
        public virtual string Style { get; set; }
        [StringLength(1024)]
        public virtual string Riderexperience { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
    }
}
