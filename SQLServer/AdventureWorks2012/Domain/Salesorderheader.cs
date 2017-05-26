using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Sample.CustomerService.Domain {
    
    public class Salesorderheader {
        public Salesorderheader() {
			Salesorderdetail = new List<Salesorderdetail>();
			Salesorderheadersalesreason = new List<Salesorderheadersalesreason>();
        }
        public virtual int Salesorderid { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Salesperson Salesperson { get; set; }
        public virtual Salesterritory Salesterritory { get; set; }
        public virtual Address Address { get; set; }
        public virtual Shipmethod Shipmethod { get; set; }
        public virtual Creditcard Creditcard { get; set; }
        public virtual Currencyrate Currencyrate { get; set; }
        [Required]
        public virtual byte Revisionnumber { get; set; }
        [Required]
        public virtual DateTime Orderdate { get; set; }
        [Required]
        public virtual DateTime Duedate { get; set; }
        public virtual DateTime? Shipdate { get; set; }
        [Required]
        public virtual byte Status { get; set; }
        [Required]
        public virtual bool Onlineorderflag { get; set; }
        [Required]
        [StringLength(25)]
        public virtual string Salesordernumber { get; set; }
        [StringLength(25)]
        public virtual string Purchaseordernumber { get; set; }
        [StringLength(15)]
        public virtual string Accountnumber { get; set; }
        [StringLength(15)]
        public virtual string Creditcardapprovalcode { get; set; }
        [Required]
        public virtual decimal Subtotal { get; set; }
        [Required]
        public virtual decimal Taxamt { get; set; }
        [Required]
        public virtual decimal Freight { get; set; }
        [Required]
        public virtual decimal Totaldue { get; set; }
        [StringLength(128)]
        public virtual string Comment { get; set; }
        [Required]
        public virtual System.Guid Rowguid { get; set; }
        [Required]
        public virtual DateTime Modifieddate { get; set; }
        public virtual IList<Salesorderdetail> Salesorderdetail { get; set; }
        public virtual IList<Salesorderheadersalesreason> Salesorderheadersalesreason { get; set; }
    }
}
