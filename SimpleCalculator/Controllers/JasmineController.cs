using System;
using System.Web.Mvc;

namespace SimpleCalculator.Controllers
{
    public class JasmineController : Controller
    {
        public ViewResult Run()
        {
            return View("SpecRunner");
        }
    }
}
