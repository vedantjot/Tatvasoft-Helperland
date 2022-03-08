using helperland1._0.Models;
using helperland1._0.Models.Data;
using helperland1._0.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace helperland1._0.Controllers
{
    public class ServiceProviderController : Controller
    {

        private readonly HelperlandContext _db;

        public ServiceProviderController(HelperlandContext db)
        {
            _db = db;
        }

        public IActionResult SPServiceRequest()
        {

            int? Id = HttpContext.Session.GetInt32("userId");
            if (Id == null)
            {
                Id = Convert.ToInt32(Request.Cookies["userId"]);
            }

            if (Id == null)
            {
                return RedirectToAction("Index", "Public", new { loginFail = "true" });
            }
            User user = _db.Users.FirstOrDefault(x => x.UserId == Id);
            int userTypeId = user.UserTypeId;
            if (userTypeId != 1)
            {
                return RedirectToAction("Index", "Public");

            }


            ViewBag.Name = user.FirstName;
            ViewBag.UserType = user.UserTypeId;


            List<SPDashboard> dashboardTable = new List<SPDashboard>();

            var ServiceRequest = _db.ServiceRequests.Where(x => x.ZipCode == user.ZipCode && x.Status == 1).ToList();

            if (ServiceRequest.Any())
            {
                foreach (var req in ServiceRequest)
                {
                    SPDashboard temp = new SPDashboard();


                    temp.ServiceRequestId = req.ServiceRequestId;
                    var StartDate = req.ServiceStartDate.ToString();
                    //temp.Date = StartDate.Substring(0, 10);
                    //temp.StartTime = StartDate.Substring(11);
                    temp.Date = req.ServiceStartDate.ToString("dd/MM/yyyy");
                    temp.StartTime = req.ServiceStartDate.AddHours(0).ToString("HH:mm ");
                    var totaltime = (double)(req.ServiceHours + req.ExtraHours);
                    temp.EndTime = req.ServiceStartDate.AddHours(totaltime).ToString("HH:mm ");
                    temp.Status = (int)req.Status;
                    temp.TotalCost = req.TotalCost;
                    temp.HasPet = req.HasPets;
                    temp.Comments = req.Comments;


                    User customer = _db.Users.FirstOrDefault(x => x.UserId == req.UserId);
                    temp.CustomerName=customer.FirstName+" "+customer.LastName;

                    ServiceRequestAddress Address = (ServiceRequestAddress)_db.ServiceRequestAddresses.FirstOrDefault(x => x.ServiceRequestId == req.ServiceRequestId);

                    temp.Address = Address.AddressLine1 + ", " + Address.AddressLine2 + ", " + Address.City + " - " + Address.PostalCode;

                    List<ServiceRequestExtra> SRExtra = _db.ServiceRequestExtras.Where(x => x.ServiceRequestId == req.ServiceRequestId).ToList();

                    foreach (ServiceRequestExtra row in SRExtra)
                    {
                        if (row.ServiceExtraId == 1)
                        {
                            temp.Cabinet = true;
                        }
                        else if (row.ServiceExtraId == 2)
                        {
                            temp.Oven = true;
                        }
                        else if (row.ServiceExtraId == 3)
                        {
                            temp.Window = true;
                        }
                        else if (row.ServiceExtraId == 4)
                        {
                            temp.Fridge = true;
                        }
                        else
                        {
                            temp.Laundry = true;
                        }
                    }

                    dashboardTable.Add(temp);






                }


            }


            return View(dashboardTable);






        }
    }
}
