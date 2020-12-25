using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Career_Search_Project.Areas.Admin.Data;
using Career_Search_Project.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Career_Search_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class JobEmployersController : Controller
    {
        private readonly ApplicationDbContext _repo;
        private readonly UserManager<User> _userManager;

        public JobEmployersController(ApplicationDbContext repo, UserManager<User> userManager)
        {
            _repo = repo;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _repo.JobEmployers.Include(j => j.Industry); //.Include(j => j.TopJob);
            return View(await applicationDbContext.ToListAsync());
        }

        [HttpGet]

        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var jobEmployer = await _repo.JobEmployers
                .Include(j => j.Industry)
                //.Include(j => j.TopJob)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobEmployer == null)
            {
                return NotFound();
            }

            return View(jobEmployer);
        }

        [HttpGet]

        public IActionResult Create()
        {
            ViewData["IndustryId"] = new SelectList(_repo.Industries, "Id", "Name");
            ViewData["TopJobId"] = new SelectList(_repo.TopJobs, "Id", "Name");
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Location,IndustryId")] JobEmployer jobEmployer)
        {
            //var claims = HttpContext.User.HasClaim;
            //jobEmployer.User
            if (ModelState.IsValid)
            {
                _repo.Add(jobEmployer);
                await _repo.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IndustryId"] = new SelectList(_repo.Industries, "Id", "Name", jobEmployer.IndustryId);
            //ViewData["TopJobId"] = new SelectList(_repo.TopJobs, "Id", "Name", jobEmployer.TopJobId);
            return View(jobEmployer);
        }

        
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobEmployer = await _repo.JobEmployers.FindAsync(id);
            if (jobEmployer == null)
            {
                return NotFound();
            }
            ViewData["IndustryId"] = new SelectList(_repo.Industries, "Id", "Name", jobEmployer.IndustryId);
            //ViewData["TopJobId"] = new SelectList(_repo.TopJobs, "Id", "Name", jobEmployer.TopJobId);
            return View(jobEmployer);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Location,IndustryId,UserId,TopJobId")] JobEmployer jobEmployer)
        {
            if (id != jobEmployer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repo.Update(jobEmployer);
                    await _repo.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IndustryId"] = new SelectList(_repo.Industries, "Id", "Name", jobEmployer.IndustryId);
            //ViewData["TopJobId"] = new SelectList(_repo.TopJobs, "Id", "Name", jobEmployer.TopJobId);
            return View(jobEmployer);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobEmployer = await _repo.JobEmployers
                .Include(j => j.Industry)
                //.Include(j => j.TopJob)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobEmployer == null)
            {
                return NotFound();
            }

            return View(jobEmployer);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobEmployer = await _repo.JobEmployers.FindAsync(id);
            _repo.JobEmployers.Remove(jobEmployer);
            await _repo.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

       
    }
}
