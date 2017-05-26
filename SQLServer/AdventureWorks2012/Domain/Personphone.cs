using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Personphone {
        public virtual int Businessentityid { get; set; }
        public virtual string Phonenumber { get; set; }
        public virtual int Phonenumbertypeid { get; set; }
        public virtual Person Person { get; set; }
        public virtual Phonenumbertype Phonenumbertype { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Personphone;
			if (t == null) return false;
			if (Businessentityid == t.Businessentityid
			 && Phonenumber == t.Phonenumber
			 && Phonenumbertypeid == t.Phonenumbertypeid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Phonenumber.GetHashCode();
			hash = (hash * 397) ^ Phonenumbertypeid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
