using Career_Search_Project.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Career_Search_Project.ViewModel
{
    public class JobEmployerViewModel
    {
        public List<JobEmployer> JobEmployers { get; set; }
        public int Industry { get; set; }
        public string SearchString { get; set; }
    }
}
