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
    using System.Collections.Generic;
    
    public partial class PaymentDetail
    {
        public long PaymentID { get; set; }
        public Nullable<int> PlanID { get; set; }
        public Nullable<int> WorkouttypeID { get; set; }
        public string Paymenttype { get; set; }
        public Nullable<System.DateTime> PaymentFromdt { get; set; }
        public Nullable<System.DateTime> PaymentTodt { get; set; }
        public Nullable<decimal> PaymentAmount { get; set; }
        public Nullable<System.DateTime> NextRenwalDate { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> ModifyUserID { get; set; }
        public string RecStatus { get; set; }
        public Nullable<long> MemberID { get; set; }
        public string MemberNo { get; set; }
    }
}
