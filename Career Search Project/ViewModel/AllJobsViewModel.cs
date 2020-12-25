using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Career_Search_Project.Areas.Admin.Models;

namespace Career_Search_Project.ViewModel
{
    public class AllJobsViewModel
    {
        
            public List<JobInformation> Jobs { get; set; }
            public int Industry { get; set; }
            public string SearchString { get; set; }
        
    }
}
