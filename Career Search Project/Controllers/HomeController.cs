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
using Career_Search_Project.Areas.Admin.ViewModel;

namespace Career_Search_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJobSeekerRepository _repo;

        private readonly IJobInformationRepository _jrepo;
        private readonly IFunctionAreaRepository _frepo;
        private readonly ITopJobRepository _trepo;
        private readonly IIndustryRepository _irepo;
        private readonly IJobEmployerRepository _erepo;
        private readonly IWalkInRepository _wrepo;


        public HomeController(IJobSeekerRepository repo, IJobInformationRepository jrepo, IFunctionAreaRepository frepo, ITopJobRepository trepo, IIndustryRepository irepo, IJobEmployerRepository erepo, IWalkInRepository wrepo)
        {
            _frepo = frepo;
            _trepo = trepo;
            _irepo = irepo;
            _repo = repo;
            _jrepo = jrepo;
            _erepo = erepo;
            _wrepo = wrepo;
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

        public async Task<IActionResult> WalkIn(WalkInViewModel model)
        {
            // Industry dropdown list
            ViewData["Industry"] = new SelectList(await _irepo.GetAll(), "Id", "Name", model.Industry);

            var walk = await _wrepo.GetAll();

            if (!string.IsNullOrEmpty(model.SearchString))
            {
                walk = walk.Where(s => s.JobName.ToLower().Contains(model.SearchString.ToLower()));
            }

            if (model.Industry != 0)
            {
                walk = walk.Where(x => x.IndustryId == model.Industry);
            }

            var vm = new WalkInViewModel()
            {
                WalkIn = walk.ToList()
            };
            return View(vm);
        }



        public async Task<IActionResult> JobEmployer(JobEmployerViewModel model)
        {
            // Industry dropdown list
            ViewData["Industry"] = new SelectList(await _irepo.GetAll(), "Id", "Name", model.Industry);

            var JobEmployer = await _erepo.GetAll();

            if (!string.IsNullOrEmpty(model.SearchString))
            {
                JobEmployer = JobEmployer.Where(s => s.Name.ToLower().Contains(model.SearchString.ToLower()));
            }

            if (model.Industry != 0)
            {
                JobEmployer = JobEmployer.Where(x => x.IndustryId == model.Industry);
            }

            var vm = new JobEmployerViewModel()
            {
                JobEmployers = JobEmployer.ToList()
            };
            return View(vm);
        }

        public async Task<IActionResult> TopJobs(TopJobsViewModel model)
        {
            // Industry dropdown list
            ViewData["Industry"] = new SelectList(await _irepo.GetAll(), "Id", "Name", model.Industry);

            var topJobs = await _trepo.GetAll();

            if (!string.IsNullOrEmpty(model.SearchString))
            {
                topJobs = topJobs.Where(s => s.Name.ToLower().Contains(model.SearchString.ToLower()));
            }

            if (model.Industry != 0)
            {
                topJobs = topJobs.Where(x => x.IndustryId == model.Industry);
            }

            var vm = new TopJobsViewModel()
            {
                TopJobs = topJobs.ToList()
            };
            return View(vm);
        }

        public async Task<IActionResult> JobSeeker(JobSeekerViewModel model)
        {
            // Industry dropdown list
            ViewData["FunctionalArea"] = new SelectList(await _frepo.GetAll(), "Id", "Name", model.FunctionalArea);

            var jobSeeker = await _repo.GetAll();

            if (!string.IsNullOrEmpty(model.SearchString))
            {
                jobSeeker = jobSeeker.Where(s => s.Name.ToLower().Contains(model.SearchString.ToLower()));
            }

            if (model.FunctionalArea != 0)
            {
                jobSeeker = jobSeeker.Where(x => x.FunctionalAreaId == model.FunctionalArea);
            }

            var vm = new JobSeekerViewModel()
            {
                JobSeekers = jobSeeker.ToList()
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

        //public IActionResult Walkin()
        //{
        //    return View();
        //}


    }
}
