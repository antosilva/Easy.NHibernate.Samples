using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Salespersonquotahistory {
        public virtual int Businessentityid { get; set; }
        public virtual DateTime Quotadate { get; set; }
        public virtual Salesperson Salesperson { get; set; }
        [Required]
        public virtual decimal Salesquota { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Salespersonquotahistory;
			if (t == null) return false;
			if (Businessentityid == t.Businessentityid
			 && Quotadate == t.Quotadate)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Quotadate.GetHashCode();

			return hash;
        }
        #endregion
    }
}
