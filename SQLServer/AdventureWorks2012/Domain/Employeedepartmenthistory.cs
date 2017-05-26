using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Employeedepartmenthistory {
        public virtual int Businessentityid { get; set; }
        public virtual short Departmentid { get; set; }
        public virtual byte Shiftid { get; set; }
        public virtual DateTime Startdate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Department Department { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual DateTime? Enddate { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Employeedepartmenthistory;
			if (t == null) return false;
			if (Businessentityid == t.Businessentityid
			 && Departmentid == t.Departmentid
			 && Shiftid == t.Shiftid
			 && Startdate == t.Startdate)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Departmentid.GetHashCode();
			hash = (hash * 397) ^ Shiftid.GetHashCode();
			hash = (hash * 397) ^ Startdate.GetHashCode();

			return hash;
        }
        #endregion
    }
}
