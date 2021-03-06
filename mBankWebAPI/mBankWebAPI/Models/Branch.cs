//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mBankWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Branch
    {
        public Branch()
        {
            this.Accounts = new HashSet<Account>();
            this.Agents = new HashSet<Agent>();
            this.Managers = new HashSet<Manager>();
            this.Products = new HashSet<Product>();
            this.Transaction_details = new HashSet<Transaction_details>();
            this.UserDetails = new HashSet<UserDetail>();
        }
    
        public int ID { get; set; }
        public Nullable<int> BankId { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ContactNo { get; set; }
        public Nullable<int> PinCode { get; set; }
        public string Website { get; set; }
        public string IFSCCode { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> LanguageId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<bool> Deleted { get; set; }
    
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Agent> Agents { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual Language Language { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Transaction_details> Transaction_details { get; set; }
        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}
