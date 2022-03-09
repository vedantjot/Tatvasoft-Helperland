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



        public int CheckConflict()
        {

            int? Id = HttpContext.Session.GetInt32("userId");
            if (Id == null)
            {
                Id = Convert.ToInt32(Request.Cookies["userId"]);
            }

            int SRID = 21;

            ServiceRequest request = _db.ServiceRequests.FirstOrDefault(x => x.ServiceRequestId == SRID);

            String reqdate = request.ServiceStartDate.ToString("yyyy-MM-dd");
            Console.WriteLine(reqdate);

            String startDateStr= reqdate+" 00:00:00.000";
            String endDateStr = reqdate + " 23:59:59.999";

            Console.WriteLine(startDateStr);

            DateTime startDate = DateTime.ParseExact(startDateStr, "yyyy-MM-dd HH:mm:ss.fff",
                                       System.Globalization.CultureInfo.InvariantCulture);

            DateTime endDate = DateTime.ParseExact(endDateStr, "yyyy-MM-dd HH:mm:ss.fff",
                                       System.Globalization.CultureInfo.InvariantCulture);

            List < ServiceRequest > list = _db.ServiceRequests.Where(x => (x.ServiceProviderId == Id) && (x.Status==2) && (x.ServiceStartDate > startDate && x.ServiceStartDate < endDate) ).ToList();

            double mins = ((double)(request.ServiceHours + request.ExtraHours)) * 60;
            DateTime endTimeRequest = request.ServiceStartDate.AddMinutes(mins+60);

            request.ServiceStartDate = request.ServiceStartDate.AddMinutes(60);

            foreach (ServiceRequest booked in list)
            {
                mins = ((double)(booked.ServiceHours + booked.ExtraHours)) * 60;
                DateTime endTimeBooked = booked.ServiceStartDate.AddMinutes(mins);

                if(request.ServiceStartDate<booked.ServiceStartDate)
                {
                    if(endTimeRequest<booked.ServiceStartDate)
                    {
                        return -1;
                    }
                    else
                    {
                        return booked.ServiceRequestId;
                    }
                }
                else
                {
                    if(request.ServiceStartDate<endTimeBooked)
                    {
                        return booked.ServiceRequestId;
                    }
                }

            }

            //String result = "";
            //foreach(var temp in list)
            //{
            //    result = result + " " + temp.ServiceRequestId;

            //}
            //Console.WriteLine(result);

            return -1;

        }
    }
}
