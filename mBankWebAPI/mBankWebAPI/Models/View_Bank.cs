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
    
    public partial class View_Bank
    {
        public int ID { get; set; }
        public string BankName { get; set; }
        public Nullable<int> SuperAdminId { get; set; }
        public Nullable<int> AdminId { get; set; }
        public string BankShortName { get; set; }
        public string BankAddress { get; set; }
        public string RegistrationNo { get; set; }
        public string ContactNo1 { get; set; }
        public string ContactNo2 { get; set; }
        public Nullable<System.TimeSpan> WorkingHours { get; set; }
        public string BankLogo { get; set; }
        public string Website { get; set; }
        public string BankDocument { get; set; }
        public Nullable<int> PinCode { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> LanguageId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<bool> Deleted { get; set; }
    }
}