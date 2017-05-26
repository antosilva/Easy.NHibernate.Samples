using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Productmodelillustration {
        public virtual int Productmodelid { get; set; }
        public virtual int Illustrationid { get; set; }
        public virtual Productmodel Productmodel { get; set; }
        public virtual Illustration Illustration { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Productmodelillustration;
			if (t == null) return false;
			if (Productmodelid == t.Productmodelid
			 && Illustrationid == t.Illustrationid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Productmodelid.GetHashCode();
			hash = (hash * 397) ^ Illustrationid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
