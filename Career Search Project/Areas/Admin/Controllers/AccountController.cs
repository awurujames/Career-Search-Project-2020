using Career_Search_Project.Areas.Admin.Models;
using Career_Search_Project.Areas.Admin.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Career_Search_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;

        public AccountController(SignInManager<User> signInManager,
        RoleManager<IdentityRole> roleManager,
        UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(AccountLoginViewModel model, string returnUrl = null)
        {
            if (!ModelState.IsValid)
                return View(model);
            ////var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

            if (result.Succeeded)
            {
                User user = await _userManager.FindByEmailAsync(model.Email);

                if(await _userManager.IsInRoleAsync(user, "Administrator"))
                {
                    if (returnUrl != null)
                        return LocalRedirect(returnUrl); // the localredirect is to avoid 0RedirectVulnearability Attack
                    else
                        return RedirectToAction("Index", "Dashboard");
                }

                if (await _userManager.IsInRoleAsync(user, "JobSeeker"))
                {
                    if (returnUrl != null && !returnUrl.ToLower().Contains("admin"))
                        return LocalRedirect(returnUrl); // the localredirect is to avoid 0RedirectVulnearability Attack
                    else
                        return RedirectToAction("AllJobs", "Home", new { Area = "" });
                }


                if (await _userManager.IsInRoleAsync(user, "JobEmployer"))
                {
                    if (returnUrl != null && !returnUrl.ToLower().Contains("admin"))
                        return LocalRedirect(returnUrl); // the localredirect is to avoid 0RedirectVulnearability Attack
                    else
                        return RedirectToAction("JobEmployer", "Home", new { Area=""});
                }



                if (returnUrl != null)
                    return LocalRedirect(returnUrl); // the localredirect is to avoid 0RedirectVulnearability Attack
                else
                    return RedirectToAction("Index", "Dashboard");

            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login details");
            }

            return View(model);
        }

        [HttpGet]
        //[Authorize(Roles = "Administrator")]
        [AllowAnonymous]

        public IActionResult Register()
        {

            var model = new AccountRegisterViewModel();
            model.UserRoles = GetRolesDropdown();

            return View(model);

        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> RegisterAsync(AccountRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {

                var user = new User { FullName = model.FullName, Email = model.Email, Tel = model.Tel, UserName = model.Email };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {

                    await _userManager.AddToRoleAsync(user, model.Role);

                    TempData["StatusMessage"] = "New account created successfully";
                    return RedirectToAction("Register");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    model.UserRoles = GetRolesDropdown();

                }

            }
            model.UserRoles = GetRolesDropdown();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("AllJobs", "Home", new { Area=""});
        }
            


        [NonAction]
        public ICollection<SelectListItem> GetRolesDropdown()
        {
            return _roleManager.Roles.Select(r => new SelectListItem { Text = r.Name, Value = r.Name }).ToList();
        }

        public IActionResult Accessdenied()
        {
            return View();
        }
    }
    
    
}