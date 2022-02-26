using helperland1._0.Models;
using helperland1._0.Models.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace helperland1._0.Controllers
{
    public class PublicController : Controller
    {
        private readonly ILogger<PublicController> _logger;
        private readonly HelperlandContext _db;
        private readonly IWebHostEnvironment _webHostEnv;
        public PublicController(HelperlandContext db, IWebHostEnvironment webHostEnv, ILogger<PublicController> logger)
        {
            _db = db;
            _webHostEnv = webHostEnv;
            _logger = logger;
        }

       

       /* public PublicController(ILogger<PublicController> logger)
        {
            _logger = logger;
        }*/

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("userId") != null)
            {
                var id = HttpContext.Session.GetInt32("userId");
                User user = _db.Users.Find(id);
                ViewBag.Name = user.FirstName;
                ViewBag.UserType = user.UserTypeId;

            }
            else if (Request.Cookies["userId"] != null)
            {
                var user = _db.Users.FirstOrDefault(x => x.UserId == Convert.ToInt32(Request.Cookies["userId"]));
                ViewBag.Name = user.FirstName;
                ViewBag.UserType = user.UserTypeId;
            }
            return View();
            
        }

        public IActionResult Price()
        {
            if (HttpContext.Session.GetInt32("userId") != null)
            {
                var id = HttpContext.Session.GetInt32("userId");
                User user = _db.Users.Find(id);
                ViewBag.Name = user.FirstName;
                ViewBag.UserType = user.UserTypeId;

            }
            else if (Request.Cookies["userId"] != null)
            {
                var user = _db.Users.FirstOrDefault(x => x.UserId == Convert.ToInt32(Request.Cookies["userId"]));
                ViewBag.Name = user.FirstName;
                ViewBag.UserType = user.UserTypeId;
            }
            return View();
        }
        public IActionResult Faq()
        {
            if (HttpContext.Session.GetInt32("userId") != null)
            {
                var id = HttpContext.Session.GetInt32("userId");
                User user = _db.Users.Find(id);
                ViewBag.Name = user.FirstName;
                ViewBag.UserType = user.UserTypeId;

            }
            else if (Request.Cookies["userId"] != null)
            {
                var user = _db.Users.FirstOrDefault(x => x.UserId == Convert.ToInt32(Request.Cookies["userId"]));
                ViewBag.Name = user.FirstName;
                ViewBag.UserType = user.UserTypeId;
            }
            return View();
        }
        public IActionResult Contactus()
        {
            if (HttpContext.Session.GetInt32("userId") != null)
            {
                var id = HttpContext.Session.GetInt32("userId");
                User user = _db.Users.Find(id);
                ViewBag.Name = user.FirstName;
                ViewBag.UserType = user.UserTypeId;

            }
            else if (Request.Cookies["userId"] != null)
            {
                var user = _db.Users.FirstOrDefault(x => x.UserId == Convert.ToInt32(Request.Cookies["userId"]));
                ViewBag.Name = user.FirstName;
                ViewBag.UserType = user.UserTypeId;
            }
            return View();
        }

        [HttpPost]
        public IActionResult Contactus(ContactU contactu)
        {

            if (ModelState.IsValid)
            {
                if (contactu.Attach != null)
                {
                    string folder = "contactFiles/";
                    folder += Guid.NewGuid().ToString() + "_" + contactu.Attach.FileName;
                    string serverFolder = Path.Combine(_webHostEnv.WebRootPath, folder);
                    contactu.Attach.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
                    contactu.FileName = folder;
                    contactu.UploadFileName = contactu.Attach.FileName;
                }
                contactu.CreatedOn = DateTime.Now;
                _db.ContactUs.Add(contactu);
                contactu.Name += contactu.LastName;
                _db.SaveChanges();
                return RedirectToAction("Index", "Public");
            }
            return View();

        }

        public IActionResult About()
        {
            if (HttpContext.Session.GetInt32("userId") != null)
            {
                var id = HttpContext.Session.GetInt32("userId");
                User user = _db.Users.Find(id);
                ViewBag.Name = user.FirstName;
                ViewBag.UserType = user.UserTypeId;

            }
            else if (Request.Cookies["userId"] != null)
            {
                var user = _db.Users.FirstOrDefault(x => x.UserId == Convert.ToInt32(Request.Cookies["userId"]));
                ViewBag.Name = user.FirstName;
                ViewBag.UserType = user.UserTypeId;
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
