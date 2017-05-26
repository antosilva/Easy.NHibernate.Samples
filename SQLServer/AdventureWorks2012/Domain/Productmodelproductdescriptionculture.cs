using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Productmodelproductdescriptionculture {
        public virtual int Productmodelid { get; set; }
        public virtual int Productdescriptionid { get; set; }
        public virtual string Cultureid { get; set; }
        public virtual Productmodel Productmodel { get; set; }
        public virtual Productdescription Productdescription { get; set; }
        public virtual Culture Culture { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Productmodelproductdescriptionculture;
			if (t == null) return false;
			if (Productmodelid == t.Productmodelid
			 && Productdescriptionid == t.Productdescriptionid
			 && Cultureid == t.Cultureid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Productmodelid.GetHashCode();
			hash = (hash * 397) ^ Productdescriptionid.GetHashCode();
			hash = (hash * 397) ^ Cultureid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
