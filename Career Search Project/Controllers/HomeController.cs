using Career_Search_Project.Areas.Admin.Data;
using Career_Search_Project.Areas.Admin.Repository;
using Career_Search_Project.Areas.Admin.Repository.Repository;
using Career_Search_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Career_Search_Project.ViewModel;

namespace Career_Search_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJobSeekerRepository _repo;

        private readonly IJobInformationRepository _jrepo;
        private readonly IFunctionAreaRepository _frepo;
        private readonly ITopJobRepository _trepo;
        private readonly IIndustryRepository _irepo;

        public HomeController(IJobSeekerRepository repo, IJobInformationRepository jrepo, IFunctionAreaRepository frepo, ITopJobRepository trepo, IIndustryRepository irepo)
        {
            _frepo = frepo;
            _trepo = trepo;
            _irepo = irepo;
            _repo = repo;
            _jrepo = jrepo;

        }



        

        public async Task<IActionResult> Index()
        {
            var model = await _repo.GetAll();
            return View(model);
        }


        public async Task <IActionResult> AllJobs(AllJobsViewModel model)
        {
            // Industry dropdown list
            ViewData["Industry"] = new SelectList(await _irepo.GetAll(), "Id", "Name", model.Industry);

            var jobs = await _jrepo.GetAll();

            if (!string.IsNullOrEmpty(model.SearchString))
            {
                jobs = jobs.Where(s => s.Name.ToLower().Contains(model.SearchString.ToLower()));
            }

            if (model.Industry != 0)
            {
                jobs = jobs.Where(x => x.IndustryId == model.Industry);
            }

            var vm = new AllJobsViewModel()
            {
                Jobs = jobs.ToList()
            };
            return View(vm);
        }


        public async Task<IActionResult> FunctionalAreas()
        {
            var model = await _frepo.GetAll();
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Walkin()
        {
            return View();
        }


    }
}
