using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Orderdetails {
        public virtual int Orderid { get; set; }
        public virtual int Productid { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual Products Products { get; set; }
        [Required]
        public virtual decimal Unitprice { get; set; }
        [Required]
        public virtual short Qty { get; set; }
        [Required]
        public virtual double Discount { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Orderdetails;
			if (t == null) return false;
			if (Orderid == t.Orderid
			 && Productid == t.Productid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Orderid.GetHashCode();
			hash = (hash * 397) ^ Productid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
