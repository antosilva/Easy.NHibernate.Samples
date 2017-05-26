using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Productphoto {
        public Productphoto() {
			Productproductphoto = new List<Productproductphoto>();
        }
        public virtual int Productphotoid { get; set; }
        public virtual byte[] Thumbnailphoto { get; set; }
        [StringLength(50)]
        public virtual string Thumbnailphotofilename { get; set; }
        public virtual byte[] Largephoto { get; set; }
        [StringLength(50)]
        public virtual string Largephotofilename { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Productproductphoto> Productproductphoto { get; set; }
    }
}
