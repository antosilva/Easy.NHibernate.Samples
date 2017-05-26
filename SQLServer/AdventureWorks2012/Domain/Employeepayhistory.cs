using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Employeepayhistory {
        public virtual int Businessentityid { get; set; }
        public virtual DateTime Ratechangedate { get; set; }
        public virtual Employee Employee { get; set; }
        [Required]
        public virtual decimal Rate { get; set; }
        [Required]
        public virtual byte Payfrequency { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Employeepayhistory;
			if (t == null) return false;
			if (Businessentityid == t.Businessentityid
			 && Ratechangedate == t.Ratechangedate)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Ratechangedate.GetHashCode();

			return hash;
        }
        #endregion
    }
}
