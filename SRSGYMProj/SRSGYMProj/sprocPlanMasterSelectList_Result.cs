//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRSGYMProj
{
    using System;
    
    public partial class sprocPlanMasterSelectList_Result
    {
        public int PlanID { get; set; }
        public string PlanName { get; set; }
        public Nullable<decimal> PlanAmount { get; set; }
        public string ServiceTax { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> ModifyUserID { get; set; }
        public string RecStatus { get; set; }
        public Nullable<decimal> TotalAmout { get; set; }
    }
}