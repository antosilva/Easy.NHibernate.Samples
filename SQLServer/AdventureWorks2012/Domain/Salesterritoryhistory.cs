using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Salesterritoryhistory {
        public virtual int Businessentityid { get; set; }
        public virtual int Territoryid { get; set; }
        public virtual DateTime Startdate { get; set; }
        public virtual Salesperson Salesperson { get; set; }
        public virtual Salesterritory Salesterritory { get; set; }
        public virtual DateTime? Enddate { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Salesterritoryhistory;
			if (t == null) return false;
			if (Businessentityid == t.Businessentityid
			 && Territoryid == t.Territoryid
			 && Startdate == t.Startdate)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Territoryid.GetHashCode();
			hash = (hash * 397) ^ Startdate.GetHashCode();

			return hash;
        }
        #endregion
    }
}
