using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); //Return these methods too -> ViewResult, PartialViewResult, JsonResult
        }

        public ViewResult About()
        {
            return View(); //return view only 
        }
    }
}

//-----------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }

        public string Display()
        {
            return "Hello Abdullah";
        }

        public int DisplayID(int id)
        {
            return id;
        }
    }
}

//-----------------------------------------------------------------

