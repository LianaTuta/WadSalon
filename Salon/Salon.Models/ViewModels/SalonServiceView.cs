using Salon.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Model.ViewModels
{
    public class SalonServiceView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SalonId { get; set; }
        public SalonModel Salon { get; set; }

        public DateTime AppointmentDate {  get; set; }
    }
}
