using Salon.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Model.ViewModels
{
    public  class AppoinmentViewModel
    {
        public int Id { get; set; }
        public SalonService Service { get; set; }
        public DateTime AppoinmentDate { get; set; }

        public DateTime EditAppoinmentDate { get; set; }
    }
}
