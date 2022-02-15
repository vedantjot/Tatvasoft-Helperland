using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using helperland1._0.Models;
using helperland1._0.Models.Data;
using helperland1._0.ViewModel;


using System;
using System.Linq;
using System.Collections.Generic;

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

            


            if (HttpContext.Session.GetInt32("userId") != null)
            {
                var id = HttpContext.Session.GetInt32("userId");
                 User user = _db.Users.Find(id);
                ViewBag.Name = user.FirstName;
                ViewBag.UserType = user.UserTypeId;
                if (user.UserTypeId == 0)
                {
                    return PartialView();
                }
            }
            else if (Request.Cookies["userId"] != null)
            {
                var user = _db.Users.FirstOrDefault(x => x.UserId == Convert.ToInt32(Request.Cookies["userId"]));
                ViewBag.Name = user.FirstName;
                ViewBag.UserType = user.UserTypeId;
                if (user.UserTypeId == 0)
                {
                    return PartialView();
                }
            }
            return RedirectToAction("Index", "Public");


        }

        public IActionResult BookService()
        {
            if (HttpContext.Session.GetInt32("userId") != null)
            {
                var id = HttpContext.Session.GetInt32("userId");
                User user = _db.Users.Find(id);
                ViewBag.Name = user.FirstName;
                ViewBag.UserType = user.UserTypeId;
                if (user.UserTypeId == 0)
                {
                    return PartialView();
                }
            }
            else if (Request.Cookies["userId"] != null)
            {
                var user = _db.Users.FirstOrDefault(x => x.UserId == Convert.ToInt32(Request.Cookies["userId"]));
                ViewBag.Name = user.FirstName;
                ViewBag.UserType = user.UserTypeId;
                if (user.UserTypeId == 0)
                {
                    return PartialView();
                }
            }
            return RedirectToAction("Index", "Public");

        }

        [HttpPost]
        public IActionResult  ValidPostalCode(PostalCode obj)
        {
            
           
            var list = _db.Users.Where(x => (x.ZipCode == obj.postalcode)&& (x.UserTypeId==1)).ToList();


            if (list.Count() > 0)
            {
                

              

                return Ok(Json("true"));
            }
            TempData["wrongZipCode"] = "Postal code you have entered is not valid.";
            return Ok(Json("false"));
        }

        [HttpPost]
        public ActionResult ScheduleService(ScheduleService schedule)
        {
           
             if (ModelState.IsValid)
             {

                
                 return Ok(Json("true"));


             }
             else
             {
               
                return Ok(Json("false"));
             }

         

        }


        [HttpGet]
        public JsonResult DetailsService(PostalCode obj)
        {

            List<DetailService> Addresses = new List<DetailService>();
            int? Id = HttpContext.Session.GetInt32("userId");
           
            string postalcode = obj.postalcode;
            Console.WriteLine(obj.postalcode);
            var table = _db.UserAddresses.Where(x => x.UserId == Id && x.PostalCode == postalcode).ToList();
            Console.WriteLine(table.ToString());

            foreach (var add in table)
            {
                Console.WriteLine("1");
                DetailService useradd = new DetailService();
                useradd.AddressId = add.AddressId;
                useradd.AddressLine1 = add.AddressLine1;
                useradd.AddressLine2 = add.AddressLine2;
                useradd.City = add.City;
                useradd.PostalCode = add.PostalCode;
                useradd.Mobile = add.Mobile;
                useradd.isDefault = add.IsDefault;
                Console.WriteLine(add.AddressLine1);
                Addresses.Add(useradd);
            }
            Console.WriteLine("2");

            return new JsonResult(Addresses);
        }


    }
}
