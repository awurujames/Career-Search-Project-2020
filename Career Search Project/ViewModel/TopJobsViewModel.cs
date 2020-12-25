using Career_Search_Project.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Career_Search_Project.ViewModel
{
    public class TopJobsViewModel
    {
        public List<TopJob> TopJobs { get; set; }
        public int Industry { get; set; }
        public string SearchString { get; set; }
    }
}
