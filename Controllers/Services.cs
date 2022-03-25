using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebsite.Controllers
{
    public class Services : Controller
    {
        public IActionResult TextAnnotation()
        {
            return View();
        }
        public IActionResult AudioTransciption()
        {
            return View();
        }
        public IActionResult ImageAnnotation()
        {
            return View();
        }
        public IActionResult ContentModeration()
        {
            return View();
        }
        public IActionResult ProductCategorization()
        {
            return View();
        }
        public IActionResult SentimentAnalysis()
        {
            return View();
        }
    }
}
