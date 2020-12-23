using Career_Search_Project.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Career_Search_Project.Areas.Admin.ViewModel
{
    public class JobTypeViewModel
    {
        public string FullTime { get; set; }
        public string PartTime { get; set; }
        public string Temporary { get; set; }
        public string Contract { get; set; }
        public ICollection<JobInformation> JobInformations { get; set; }
        public ICollection<JobType> JobTypes { get; set; }
        public ICollection<WalkIn> WalkIns { get; set; }
    }
}
