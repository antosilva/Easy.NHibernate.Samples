using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Purchaseorderdetail {
        public virtual int Purchaseorderid { get; set; }
        public virtual int Purchaseorderdetailid { get; set; }
        public virtual Purchaseorderheader Purchaseorderheader { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public virtual DateTime Duedate { get; set; }
        [Required]
        public virtual short Orderqty { get; set; }
        [Required]
        public virtual decimal Unitprice { get; set; }
        [Required]
        public virtual decimal Linetotal { get; set; }
        [Required]
        public virtual decimal Receivedqty { get; set; }
        [Required]
        public virtual decimal Rejectedqty { get; set; }
        [Required]
        public virtual decimal Stockedqty { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Purchaseorderdetail;
			if (t == null) return false;
			if (Purchaseorderid == t.Purchaseorderid
			 && Purchaseorderdetailid == t.Purchaseorderdetailid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Purchaseorderid.GetHashCode();
			hash = (hash * 397) ^ Purchaseorderdetailid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
