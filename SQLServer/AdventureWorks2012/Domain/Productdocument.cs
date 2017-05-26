using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Productdocument {
        public virtual int Productid { get; set; }
        public virtual string Documentnode { get; set; }
        public virtual Product Product { get; set; }
        public virtual Document Document { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Productdocument;
			if (t == null) return false;
			if (Productid == t.Productid
			 && Documentnode == t.Documentnode)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Productid.GetHashCode();
			hash = (hash * 397) ^ Documentnode.GetHashCode();

			return hash;
        }
        #endregion
    }
}
