//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AllPointsTransport.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Truck
    {
        public int TruckID { get; set; }
        public Nullable<bool> Active { get; set; }
        public string TruckNum { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public string LicensePlate { get; set; }
        public string State { get; set; }
        public string Color { get; set; }
        public string TitleOwner { get; set; }
        public Nullable<decimal> TruckPayPct { get; set; }
        public Nullable<decimal> FSDeductionPct { get; set; }
        public string Referral { get; set; }
        public Nullable<decimal> ReferralPct { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
