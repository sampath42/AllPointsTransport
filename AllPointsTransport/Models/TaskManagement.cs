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
    
    public partial class TaskManagement
    {
        public int ID { get; set; }
        public string AssignedTo { get; set; }
        public string Priority { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string ProNum { get; set; }
        public string Task { get; set; }
        public Nullable<bool> Complete { get; set; }
        public Nullable<System.DateTime> CompletedTimeStamp { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
