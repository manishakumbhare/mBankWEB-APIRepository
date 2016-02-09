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
    
    public partial class Admin
    {
        public Admin()
        {
            this.Banks = new HashSet<Bank>();
            this.Managers = new HashSet<Manager>();
        }
    
        public int ID { get; set; }
        public string AdminName { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string Designation { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ContactNo1 { get; set; }
        public string ContactNo2 { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<bool> Deleted { get; set; }
    
        public virtual ICollection<Bank> Banks { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual UsersRole UsersRole { get; set; }
    }
}