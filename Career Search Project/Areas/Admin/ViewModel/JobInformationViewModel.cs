using Career_Search_Project.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Career_Search_Project.Areas.Admin.ViewModel
{
    public class JobInformationViewModel
    {
        public int Id { get; set; }
        public virtual FunctionalArea FunctionalArea { get; set; }
        public string JobLocation { get; set; }
        public int AgeLimit { get; set; }
        public int YearsOfExperience { get; set; }
        public string Qualification { get; set; }
        public string JobSummary { get; set; }
        public decimal Renumeration { get; set; }
        public virtual Industry Industry { get; set; }
        public virtual JobType JobType { get; set; }
    }
}
