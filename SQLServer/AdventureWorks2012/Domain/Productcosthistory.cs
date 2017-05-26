using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Productcosthistory {
        public virtual int Productid { get; set; }
        public virtual DateTime Startdate { get; set; }
        public virtual Product Product { get; set; }
        public virtual DateTime? Enddate { get; set; }
        [Required]
        public virtual decimal Standardcost { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Productcosthistory;
			if (t == null) return false;
			if (Productid == t.Productid
			 && Startdate == t.Startdate)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Productid.GetHashCode();
			hash = (hash * 397) ^ Startdate.GetHashCode();

			return hash;
        }
        #endregion
    }
}
