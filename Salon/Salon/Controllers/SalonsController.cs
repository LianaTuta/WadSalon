using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Runtime.Intrinsics.X86;

namespace Salon.Controllers
{
    public class SalonsController : Controller
    {
        public ActionResult Overview(SalonModel salon)
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
                Id = 3,
                Name = "Salon3",
                ImagePath = "salon1.jpg"
            };
            var sal4 = new SalonModel()
            {
                Id = 4,
                Name = "Salon4",
                ImagePath = "salon1.jpg"
            };
            var salonList = new List<SalonModel>() { sal3, sal4, sal1, sal2 };
            ViewBag.SalonList = salonList;  
            return View(salonList.ToList());
        }

        public ActionResult SalonDetails(int salonId)
        {

            var sal1 = new SalonModel()
            {
                Id = 1,
                Name = "Salon1",
                ImagePath = "salon1.jpg",
                Description = "descriere primul salon",
                Address = "Address primul salon"
            };
            var sal2 = new SalonModel()
            {
                Id = 2,
                Name = "Salon2",
                ImagePath = "salon1.jpg",
                Description = "descriere 2 salon",
                Address = "Address 2 salon"
            };
            var sal3 = new SalonModel()
            {
                Id = 3,
                Name = "Salon3",
                ImagePath = "salon1.jpg",
                Description = "descriere 3 salon",
                Address = "Address 3 salon"
            };
            var sal4 = new SalonModel()
            {
                Id = 4,
                Name = "Salon4",
                ImagePath = "salon1.jpg",
                Description = "descriere 4 salon",
                Address = "Address 4 salon"
            };
            var salonList = new List<SalonModel>() { sal3, sal4, sal1, sal2 };       
            var aux  = salonList.Find(salon => salon.Id == salonId);
            ViewBag.Salon = aux;
            return View(aux);
        }
    }
}
