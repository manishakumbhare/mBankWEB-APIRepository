﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BankEntities : DbContext
    {
        public BankEntities()
            : base("name=BankEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SuperAdmin> SuperAdmins { get; set; }
        public virtual DbSet<Transaction_details> Transaction_details { get; set; }
        public virtual DbSet<TransactionStatu> TransactionStatus { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<UsersRole> UsersRoles { get; set; }
        public virtual DbSet<View_Admin> View_Admin { get; set; }
        public virtual DbSet<View_Bank> View_Bank { get; set; }
        public virtual DbSet<View_Language> View_Language { get; set; }
        public virtual DbSet<View_Product> View_Product { get; set; }
        public virtual DbSet<View_SuperAdmin> View_SuperAdmin { get; set; }
        public virtual DbSet<View_Branch> View_Branch { get; set; }
    
        public virtual ObjectResult<SP_getSuperAdminDetail_Result> SP_getSuperAdminDetail(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_getSuperAdminDetail_Result>("SP_getSuperAdminDetail", usernameParameter);
        }
    
        public virtual ObjectResult<SP_LoginCredentials_Result> SP_LoginCredentials(string userName, string passWord)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("passWord", passWord) :
                new ObjectParameter("passWord", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LoginCredentials_Result>("SP_LoginCredentials", userNameParameter, passWordParameter);
        }
    }
}
