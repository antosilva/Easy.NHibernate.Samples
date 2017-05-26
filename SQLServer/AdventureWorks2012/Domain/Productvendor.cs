using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Productvendor {
        public virtual int Productid { get; set; }
        public virtual int Businessentityid { get; set; }
        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Unitmeasure Unitmeasure { get; set; }
        [Required]
        public virtual int Averageleadtime { get; set; }
        [Required]
        public virtual decimal Standardprice { get; set; }
        public virtual decimal? Lastreceiptcost { get; set; }
        public virtual DateTime? Lastreceiptdate { get; set; }
        [Required]
        public virtual int Minorderqty { get; set; }
        [Required]
        public virtual int Maxorderqty { get; set; }
        public virtual int? Onorderqty { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Productvendor;
			if (t == null) return false;
			if (Productid == t.Productid
			 && Businessentityid == t.Businessentityid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Productid.GetHashCode();
			hash = (hash * 397) ^ Businessentityid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
