using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Document {
        public Document() {
			Productdocument = new List<Productdocument>();
        }
        public virtual string Documentnode { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual short? Documentlevel { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string Title { get; set; }
        [Required]
        public virtual bool Folderflag { get; set; }
        [Required]
        [StringLength(400)]
        public virtual string Filename { get; set; }
        [Required]
        [StringLength(8)]
        public virtual string Fileextension { get; set; }
        [Required]
        [StringLength(5)]
        public virtual string Revision { get; set; }
        [Required]
        public virtual int Changenumber { get; set; }
        [Required]
        public virtual byte Status { get; set; }
        public virtual string Documentsummary { get; set; }
        public virtual byte[] Documentval { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Productdocument> Productdocument { get; set; }
    }
}
