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
    
    public partial class Agent
    {
        public Agent()
        {
            this.Accounts = new HashSet<Account>();
            this.Customers = new HashSet<Customer>();
            this.Transaction_details = new HashSet<Transaction_details>();
        }
    
        public int ID { get; set; }
        public string AgentName { get; set; }
        public Nullable<int> BankId { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> ManagerId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ContactNo1 { get; set; }
        public string ContactNo2 { get; set; }
        public string ProfilePhoto { get; set; }
        public Nullable<bool> IsSyncronise { get; set; }
        public Nullable<System.DateTime> SincronisationDate { get; set; }
        public Nullable<System.DateTime> BankSyncroniseDate { get; set; }
        public Nullable<System.DateTime> Createddate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<bool> Deleted { get; set; }
    
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Manager Manager { get; set; }
        public virtual UsersRole UsersRole { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Transaction_details> Transaction_details { get; set; }
    }
}
