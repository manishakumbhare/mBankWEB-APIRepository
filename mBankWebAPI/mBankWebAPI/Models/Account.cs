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
    
    public partial class Account
    {
        public Account()
        {
            this.Transaction_details = new HashSet<Transaction_details>();
        }
    
        public int ID { get; set; }
        public string ExternalAccountId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> BankId { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> AgentId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<double> Balance { get; set; }
        public Nullable<bool> IsSyncronise { get; set; }
        public Nullable<System.DateTime> BankSyncroniseDate { get; set; }
        public Nullable<System.DateTime> SyncroniseDate { get; set; }
        public Nullable<int> IstallmentDays { get; set; }
        public Nullable<double> Percentage { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<bool> Deleted { get; set; }
    
        public virtual Agent Agent { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Transaction_details> Transaction_details { get; set; }
    }
}
