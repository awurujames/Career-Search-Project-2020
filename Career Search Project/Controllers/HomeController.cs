using Career_Search_Project.Areas.Admin.Data;
using Career_Search_Project.Areas.Admin.Repository.Repository;
using Career_Search_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Career_Search_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJobSeekerRepository _repo;

        private readonly IJobInformationRepository _repository;
        private readonly IJobSeekerRepository _reposit;


        public HomeController(IJobSeekerRepository context, IJobInformationRepository cont, IJobSeekerRepository _repository1)
        {
            _repo = context;
            _repository = cont;
            _reposit = _repository1;

        }

       



        public async Task<IActionResult> Index()
        {
            var model = await _repo.GetAll();
            return View(model);
        }


        public async Task <IActionResult> AllJobs()
        {
            var model = await _repository.GetAll();
            return View(model);
        }


        public async Task<IActionResult> AllJobeSeeker()
        {
            var model = await _repository.GetAll();
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
