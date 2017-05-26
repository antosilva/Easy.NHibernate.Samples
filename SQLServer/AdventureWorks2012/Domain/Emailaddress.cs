using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Emailaddress {
        public virtual int Businessentityid { get; set; }
        public virtual int Emailaddressid { get; set; }
        public virtual Person Person { get; set; }
        [StringLength(50)]
        public virtual string Emailaddressval { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Emailaddress;
			if (t == null) return false;
			if (Businessentityid == t.Businessentityid
			 && Emailaddressid == t.Emailaddressid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Emailaddressid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
