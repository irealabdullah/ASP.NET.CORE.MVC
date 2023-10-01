using Microsoft.AspNetCore.Mvc;

namespace LayOutPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "View Data";
            ViewBag.Name = "View Bag";
            TempData["Name"] = "temp data";  //Yeh humne index method main banaya hai and we call in index.cshtml but 
            //if we access in about.cshtml we can access only tempData, others will not show 
            // we can access only one time 

            TempData.Keep();  // tempdata ko keep rakh sakte hain across multiple views
            // agar 100 index hain tu we will copy this method 100 times which is not a best practice so we will the concept called SESSIONS 
            // WE WILL USE SESSIONS INSTEAD OF TEMPDATA.KEEP()

            TempData["StudentNames"] = new List<string>()
            {
               "Hockey","Chess","Flute"
            };
            return View();  
            
        }

        public IActionResult About()
        {

            TempData.Keep();
            return View();
        }

        public IActionResult Contact()
        {
            TempData.Keep();
            return View();
        }
    }
}



//------------------------------------------------------------



@{
    ViewData["Title"] = "About";
 
}

<h1>About Page</h1>
<p>This is About page </p>


@ViewData["Name"]
@ViewBag.Name
@TempData["Name"]


@{
    foreach (var item in (List<string>)TempData["StudentNames"])
    {
        <h1>@item</h1>
    }
} 