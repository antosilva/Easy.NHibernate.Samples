using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Personcreditcard {
        public virtual int Businessentityid { get; set; }
        public virtual int Creditcardid { get; set; }
        public virtual Person Person { get; set; }
        public virtual Creditcard Creditcard { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Personcreditcard;
			if (t == null) return false;
			if (Businessentityid == t.Businessentityid
			 && Creditcardid == t.Creditcardid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Creditcardid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
