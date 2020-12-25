using Career_Search_Project.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Career_Search_Project.ViewModel
{
    public class JobSeekerViewModel
    {
        public List<JobSeeker> JobSeekers { get; set; }
        public int FunctionalArea { get; set; }
        public string SearchString { get; set; }
    }
}
