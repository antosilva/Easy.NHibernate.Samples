using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Businessentitycontact {
        public virtual int Businessentityid { get; set; }
        public virtual int Personid { get; set; }
        public virtual int Contacttypeid { get; set; }
        public virtual Businessentity Businessentity { get; set; }
        public virtual Person Person { get; set; }
        public virtual Contacttype Contacttype { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Businessentitycontact;
			if (t == null) return false;
			if (Businessentityid == t.Businessentityid
			 && Personid == t.Personid
			 && Contacttypeid == t.Contacttypeid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Personid.GetHashCode();
			hash = (hash * 397) ^ Contacttypeid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
