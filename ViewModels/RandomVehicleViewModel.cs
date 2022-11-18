using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class RandomVehicleViewModel
    {
        public List <Vehicle> Vehicle { get; set; }
        public List<Owner> Owner { get; set; }
    }
}