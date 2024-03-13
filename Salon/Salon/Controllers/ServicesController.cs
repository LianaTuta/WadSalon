using Microsoft.AspNetCore.Mvc;
using Salon.Models;

namespace Salon.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Services(int salonId)
        {
            var service1 = new ServiceModel()
            {
                Id = 1,
                Name = "Service1",
                SalonId = 1,
                Description = "Description"
            };
            var service2 = new ServiceModel()
            {
                Id = 2,
                Name = "Service1",
                SalonId = 2,
                Description = "Description"
            };
            var service3 = new ServiceModel()
            {
                Id = 3,
                Name = "Service1",
                SalonId = 3,
                Description = "Description"
            };
            var service4 = new ServiceModel()
            {
                Id = 3,
                Name = "Service1",
                SalonId = 4,
                Description = "Description"
            };
            var serviceList = new List<ServiceModel>() { service1,service2,service3,service4 };
           
            ViewBag.Services = serviceList;
            return View(serviceList);
        }

        public IActionResult SuccessfullBook(ServiceModel serviceModel)
        {
            return View(serviceModel);
        }
    }
}
