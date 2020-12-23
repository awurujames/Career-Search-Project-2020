using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Career_Search_Project.Areas.Admin.Models
{
    public class Industry
    {
        //This model store Industry Name
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection <JobInformation> JobInformations { get; set; }
        public ICollection<JobEmployer> JobEmployer { get; set; }
        public ICollection<WalkIn> WalkIn { get; set; }

    }
}
