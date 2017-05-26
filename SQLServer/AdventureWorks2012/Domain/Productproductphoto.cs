using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Productproductphoto {
        public virtual int Productid { get; set; }
        public virtual int Productphotoid { get; set; }
        public virtual Product Product { get; set; }
        public virtual Productphoto Productphoto { get; set; }
        [Required]
        public virtual bool Primary { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Productproductphoto;
			if (t == null) return false;
			if (Productid == t.Productid
			 && Productphotoid == t.Productphotoid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Productid.GetHashCode();
			hash = (hash * 397) ^ Productphotoid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
