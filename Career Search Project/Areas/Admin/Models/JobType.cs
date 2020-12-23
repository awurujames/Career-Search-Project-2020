using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Career_Search_Project.Areas.Admin.Models
{
    public class JobType
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public ICollection<JobInformation> JobInformations { get; set; }
        public ICollection<JobType> JobTypes { get; set; }
        public ICollection <WalkIn> WalkIns { get; set; }
    }
}
