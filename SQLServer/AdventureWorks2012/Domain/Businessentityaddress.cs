using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Businessentityaddress {
        public virtual int Businessentityid { get; set; }
        public virtual int Addressid { get; set; }
        public virtual int Addresstypeid { get; set; }
        public virtual Businessentity Businessentity { get; set; }
        public virtual Address Address { get; set; }
        public virtual Addresstype Addresstype { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Businessentityaddress;
			if (t == null) return false;
			if (Businessentityid == t.Businessentityid
			 && Addressid == t.Addressid
			 && Addresstypeid == t.Addresstypeid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Addressid.GetHashCode();
			hash = (hash * 397) ^ Addresstypeid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
