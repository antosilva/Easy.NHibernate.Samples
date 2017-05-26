using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Countryregioncurrency {
        public virtual string Countryregioncode { get; set; }
        public virtual string Currencycode { get; set; }
        public virtual Countryregion Countryregion { get; set; }
        public virtual Currency Currency { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Countryregioncurrency;
			if (t == null) return false;
			if (Countryregioncode == t.Countryregioncode
			 && Currencycode == t.Currencycode)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Countryregioncode.GetHashCode();
			hash = (hash * 397) ^ Currencycode.GetHashCode();

			return hash;
        }
        #endregion
    }
}
