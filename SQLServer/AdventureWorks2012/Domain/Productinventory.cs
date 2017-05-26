using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Productinventory {
        public virtual int Productid { get; set; }
        public virtual short Locationid { get; set; }
        public virtual Product Product { get; set; }
        public virtual Location Location { get; set; }
        [Required]
        [StringLength(10)]
        public virtual string Shelf { get; set; }
        [Required]
        public virtual byte Bin { get; set; }
        [Required]
        public virtual short Quantity { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Productinventory;
			if (t == null) return false;
			if (Productid == t.Productid
			 && Locationid == t.Locationid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Productid.GetHashCode();
			hash = (hash * 397) ^ Locationid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
