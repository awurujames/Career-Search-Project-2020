﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Career_Search_Project.Areas.Admin.Data;
using Career_Search_Project.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;

namespace Career_Search_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class JobInformationsController : Controller
    {
        private readonly ApplicationDbContext _repo;

        public JobInformationsController(ApplicationDbContext repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _repo.JobInformations.Include(j => j.FunctionalArea).Include(j => j.Industry).Include(j => j.JobType);
            return View(await applicationDbContext.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var jobInformation = await _repo.JobInformations
                .Include(j => j.FunctionalArea)
                .Include(j => j.Industry)
                .Include(j => j.JobType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobInformation == null)
            {
                return NotFound();
            }

            return View(jobInformation);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["FunctionalAreaId"] = new SelectList(_repo.FunctionalAreas, "Id", "Name");
            ViewData["IndustryId"] = new SelectList(_repo.Industries, "Id", "Name");
            ViewData["JobTypeId"] = new SelectList(_repo.JobTypes, "Id", "Name");
            ViewData["CompanyId"] = new SelectList(_repo.JobEmployers, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(JobInformation jobInformation)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(jobInformation);
                await _repo.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FunctionalAreaId"] = new SelectList(_repo.FunctionalAreas, "Id", "Name", jobInformation.FunctionalAreaId);
            ViewData["IndustryId"] = new SelectList(_repo.Industries, "Id", "Name", jobInformation.IndustryId);
            ViewData["JobTypeId"] = new SelectList(_repo.JobTypes, "Id", "Name", jobInformation.JobTypeId);
            ViewData["CompanyId"] = new SelectList(_repo.JobEmployers, "Id", "Name", jobInformation.CompanyId);
            return View(jobInformation);
        }
         
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var jobInformation = await _repo.JobInformations.FindAsync(id);
            if (jobInformation == null)
            {
                return NotFound();
            }
            ViewData["FunctionalAreaId"] = new SelectList(_repo.FunctionalAreas, "Id", "Name", jobInformation.FunctionalAreaId);
            ViewData["IndustryId"] = new SelectList(_repo.Industries, "Id", "Name", jobInformation.IndustryId);
            ViewData["JobTypeId"] = new SelectList(_repo.JobTypes, "Id", "Name", jobInformation.JobTypeId);
            ViewData["CompanyId"] = new SelectList(_repo.JobEmployers, "Id", "Name", jobInformation.CompanyId);
            return View(jobInformation);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,FunctionalAreaId,JobLocation,AgeLimit,YearsOfExperience,Qualification,Requirements,Responsibility,JobSummary,IndustryId,Renumeration,CompanyId,JobTypeId")] JobInformation jobInformation)
        {
            if (id != jobInformation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repo.Update(jobInformation);
                    await _repo.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FunctionalAreaId"] = new SelectList(_repo.FunctionalAreas, "Id", "Name", jobInformation.FunctionalAreaId);
            ViewData["IndustryId"] = new SelectList(_repo.Industries, "Id", "Name", jobInformation.IndustryId);
            ViewData["JobTypeId"] = new SelectList(_repo.JobTypes, "Id", "Name", jobInformation.JobTypeId);
            ViewData["CompanyId"] = new SelectList(_repo.JobEmployers, "Id", "Name", jobInformation.CompanyId);
            return View(jobInformation);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var jobInformation = await _repo.JobInformations
                .Include(j => j.FunctionalArea)
                .Include(j => j.Industry)
                .Include(j => j.JobType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobInformation == null)
            {
                return NotFound();
            }

            return View(jobInformation);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobInformation = await _repo.JobInformations.FindAsync(id);
            _repo.JobInformations.Remove(jobInformation);
            await _repo.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        
    }
}
