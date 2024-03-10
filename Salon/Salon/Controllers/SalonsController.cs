using Microsoft.AspNetCore.Mvc;
using Salon.Models;

namespace Salon.Controllers
{
    public class SalonsController : Controller
    {
        public ActionResult Index(SalonModel salon)
        {
            
            var sal1 = new SalonModel()
            {
                Id = 1,
                Name = "Salon1",
                ImagePath = "salon1.jpg"
            };
            var sal2 = new SalonModel()
            {
                Id = 2,
                Name = "Salon2",
                ImagePath = "salon1.jpg"
            };
            var sal3 = new SalonModel()
            {
                Id = 2,
                Name = "Salon3",
                ImagePath = "salon1.jpg"
            };
            var sal4 = new SalonModel()
            {
                Id = 2,
                Name = "Salon4",
                ImagePath = "salon1.jpg"
            };
            var salonList = new List<SalonModel>() { sal3, sal4, sal1, sal2 };
            ViewBag.SalonList = salonList;  
            return View(salonList.ToList());
        }
    }
}
