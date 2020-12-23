using Career_Search_Project.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Career_Search_Project.Areas.Admin.ViewModel
{
    public class JobEmployerViewModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int IndustryId { get; set; }
        public virtual User User { get; set; }
        public ICollection<JobInformation> JobInformation { get; set; }
        public ICollection<WalkIn> WalkIn { get; set; }
        public virtual TopJob TopJob { get; set; }
    }
}
