//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JOBTRACK.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public Nullable<int> OwnerId { get; set; }
        public Nullable<int> CreatorId { get; set; }
        public string Description { get; set; }
        public string status { get; set; }
        public string Priority { get; set; }
        public string Notes { get; set; }
        public string IsBookmarked { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> StatusChangedOn { get; set; }
    }
}
