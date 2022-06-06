using Microsoft.AspNetCore.Mvc;
using SimpleDotNetCoreMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleDotNetCoreMVCApp.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            var model = new CarsModel();
            model.SelectCarList.Add(new CarModelListItem()
            {
                Id = 3,
                Name = "Bugatti",
                ModelName = "Chiron",
                Price = 10000000
            });
            return View(model);
        }
    }
}
