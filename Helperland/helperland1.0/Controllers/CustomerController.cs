using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using helperland1._0.Models;
using helperland1._0.Models.Data;

using System;
using System.Linq;

namespace helperland1._0.Controllers
{
    public class CustomerController : Controller
    {

        private readonly HelperlandContext _db;

        public CustomerController(HelperlandContext db)
        {
            _db = db;
        }
        public IActionResult CustomerServiceHistory()
        {

            var Id = HttpContext.Session.GetInt32("id");
            if (Id != null)
            {
                var obj = _db.Users.FirstOrDefault(x => x.UserId == Id);
                ViewBag.Name = obj.FirstName;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Public");
            }

        }
    }
}
