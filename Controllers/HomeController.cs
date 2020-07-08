using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.ViewModels.Home;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int rowCount = 5)
        {
            var model = new IndexViewModel();
            model.Init(rowCount);
            return View(model);
        }
    }
}
