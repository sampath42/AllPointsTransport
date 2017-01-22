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
    
    public partial class Contact
    {
        public int ContactID { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Company { get; set; }
        public Nullable<bool> BillTo { get; set; }
        public Nullable<bool> Broker { get; set; }
        public Nullable<bool> EquipmentProvider { get; set; }
        public Nullable<bool> ChassisProvider { get; set; }
        public Nullable<bool> Location { get; set; }
        public Nullable<bool> RailPort { get; set; }
        public Nullable<bool> CYDepot { get; set; }
        public Nullable<bool> DallasDY { get; set; }
        public Nullable<bool> FtWorthDY { get; set; }
        public Nullable<bool> Vendor { get; set; }
        public string Description { get; set; }
        public string Contact1 { get; set; }
        public string Phone1 { get; set; }
        public string Email1 { get; set; }
        public string Contact2 { get; set; }
        public string Phone2 { get; set; }
        public string Email2 { get; set; }
        public string Fax { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string BillingCode { get; set; }
        public string CCType { get; set; }
        public string CCNum { get; set; }
        public string CCExpiration { get; set; }
        public string CCSecurityCode { get; set; }
        public string CCCardholder { get; set; }
        public string CCBillingStreet { get; set; }
        public string CCBillingZip { get; set; }
        public string MC { get; set; }
        public string Notes { get; set; }
        public Nullable<decimal> TotalCredit { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
