using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Vin { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
        public string Owner_Id { get; set; }

    }
}