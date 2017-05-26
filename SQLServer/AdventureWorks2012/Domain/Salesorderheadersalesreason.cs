using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Salesorderheadersalesreason {
        public virtual int Salesorderid { get; set; }
        public virtual int Salesreasonid { get; set; }
        public virtual Salesorderheader Salesorderheader { get; set; }
        public virtual Salesreason Salesreason { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Salesorderheadersalesreason;
			if (t == null) return false;
			if (Salesorderid == t.Salesorderid
			 && Salesreasonid == t.Salesreasonid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Salesorderid.GetHashCode();
			hash = (hash * 397) ^ Salesreasonid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
