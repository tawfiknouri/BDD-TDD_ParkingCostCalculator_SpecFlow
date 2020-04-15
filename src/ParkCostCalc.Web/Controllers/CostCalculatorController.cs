using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ParkCostCalc.Web.Controllers
{
    public class CostCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}