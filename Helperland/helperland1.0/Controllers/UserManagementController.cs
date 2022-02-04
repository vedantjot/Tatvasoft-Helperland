using helperland1._0.Models;
using helperland1._0.Models.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace helperland1._0.Controllers
{
    public class UserManagementController : Controller
    {

        private readonly HelperlandContext _db;

        public UserManagementController(HelperlandContext db)
        {
            _db = db;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                if (_db.Users.Where(x => x.Email == user.username && x.Password == user.password).Count() > 0)
                {

                    var U = _db.Users.FirstOrDefault(x => x.Email == user.username);
                    HttpContext.Session.SetInt32("id", U.UserId);

                    return RedirectToAction("CustomerServiceHistory", "Customer");
                }
                else
                {
                    TempData["add"] = "alert show";
                    TempData["fail"] = "username and password are invalid";
                    return RedirectToAction("Index", "Public", new { loginFail = "true" });

                }
            }

            TempData["add"] = "alert show";
            TempData["fail"] = "username and password are required";
            return RedirectToAction("Index", "Public", new { loginModal = "true" });





        }

        public IActionResult BecomeAProvider()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult BecomeAProvider(User user)
        {

            if (ModelState.IsValid)
            {
                if ((_db.Users.Where(x => x.Email == user.Email).Count() == 0 && _db.Users.Where(x => x.Mobile == user.Mobile).Count() == 0))
                {

                    user.CreatedDate = DateTime.Now;
                    user.ModifiedDate = DateTime.Now;
                    user.IsRegisteredUser = true;
                    user.ModifiedBy = 123;
                    user.UserTypeId = 1;

                    _db.Users.Add(user);
                    _db.SaveChanges();


                    return RedirectToAction("Index", "Public");


                }
                else
                {
                    ViewBag.message = "User already exist.";
                    return RedirectToAction("Index", "Public");


                }
            }
            return View();

        }

        public IActionResult CustomerSignUp()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult CustomerSignUp(User user)
        {

            if (ModelState.IsValid)
            {
                if ((_db.Users.Where(x => x.Email == user.Email).Count() == 0 && _db.Users.Where(x => x.Mobile == user.Mobile).Count() == 0))
                {

                    user.CreatedDate = DateTime.Now;
                    user.ModifiedDate = DateTime.Now;
                    user.IsRegisteredUser = true;
                    user.ModifiedBy = 123;
                    user.UserTypeId = 0;

                    _db.Users.Add(user);
                    _db.SaveChanges();


                    return RedirectToAction("Index", "Public");


                }
                else
                {
                    ViewBag.message = "User already exist.";
                    return RedirectToAction("Index", "Public");


                }
            }
            return View();

        }

    }
}
