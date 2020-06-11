using System;
using InsecureBindingConfiguration_POC.Data;
using InsecureBindingConfiguration_POC.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsecureBindingConfiguration_POC.Controllers
{
    public class UsersController : Controller
    { 
        // GET: Users/Edit
        public ActionResult Edit()
        {
            var repo = new UserRepository();
            var model = repo.GetTheUser();
            
            return View(model);
        }

        // POST: Users/Edit
        [HttpPost]
        public ActionResult Edit(UserDataModel user)
        {
            try
            {
                var repo = new UserRepository();
                repo.Save(user);
                return RedirectToAction(nameof(Index), "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}