using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JOBTRACKMVC.Models
{
    public class MvcTask
    {
        public int TaskId { get; set; }                                     //Declaring attributes
        [Required(ErrorMessage = "This is a Mandatory Field")]
        public string TaskName { get; set; }
        [Required(ErrorMessage = "This is a Mandatory Field")]
        public Nullable<int> OwnerId { get; set; }
        public Nullable<int> CreatorId { get; set; }
        public string Description { get; set; }
        public string status { get; set; }
        public string Priority { get; set; }
        public string Notes { get; set; }
        public string IsBookmarked { get; set; }
        public Nullable<System.DateTime> CreatedOn = DateTime.Now;/*{ get; set; }*/                 
        public Nullable<System.DateTime> StatusChangedOn = DateTime.Now;/*{ get; set; }*/
    }
}