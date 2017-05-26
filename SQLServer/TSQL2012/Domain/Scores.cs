using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Scores {
        public virtual string Testid { get; set; }
        public virtual string Studentid { get; set; }
        public virtual Tests Tests { get; set; }
        [Required]
        public virtual byte Score { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Scores;
			if (t == null) return false;
			if (Testid == t.Testid
			 && Studentid == t.Studentid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Testid.GetHashCode();
			hash = (hash * 397) ^ Studentid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
