using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Specialofferproduct {
        public Specialofferproduct() {
			Salesorderdetail = new List<Salesorderdetail>();
        }
        public virtual int Specialofferid { get; set; }
        public virtual int Productid { get; set; }
        public virtual Specialoffer Specialoffer { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Salesorderdetail> Salesorderdetail { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Specialofferproduct;
			if (t == null) return false;
			if (Specialofferid == t.Specialofferid
			 && Productid == t.Productid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Specialofferid.GetHashCode();
			hash = (hash * 397) ^ Productid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
