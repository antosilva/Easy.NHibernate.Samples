using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Workorderrouting {
        public virtual int Workorderid { get; set; }
        public virtual int Productid { get; set; }
        public virtual short Operationsequence { get; set; }
        public virtual Workorder Workorder { get; set; }
        public virtual Location Location { get; set; }
        [Required]
        public virtual DateTime Scheduledstartdate { get; set; }
        [Required]
        public virtual DateTime Scheduledenddate { get; set; }
        public virtual DateTime? Actualstartdate { get; set; }
        public virtual DateTime? Actualenddate { get; set; }
        public virtual decimal? Actualresourcehrs { get; set; }
        [Required]
        public virtual decimal Plannedcost { get; set; }
        public virtual decimal? Actualcost { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Workorderrouting;
			if (t == null) return false;
			if (Workorderid == t.Workorderid
			 && Productid == t.Productid
			 && Operationsequence == t.Operationsequence)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Workorderid.GetHashCode();
			hash = (hash * 397) ^ Productid.GetHashCode();
			hash = (hash * 397) ^ Operationsequence.GetHashCode();

			return hash;
        }
        #endregion
    }
}
