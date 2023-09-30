/*we can pass data btw controller and views:
1) ViewData
2) ViewBag
3) TempData
4) StronglyTypedViews

ViewData
•	Passes data from a controller to a view.
•	Is a dictionary of objects that is derived from the ViewDataDictionary class.
•	Some of the characteristics of ViewData are as follows:
•	The life of a ViewData object exists only during the current request.
•	The value of ViewData becomes null if the request is redirected.
•	ViewData requires typecasting when you use complex data type to avoid error.

The general syntax of ViewData is as follows:
ViewData[“<Key>”] = <Value>;

value is the object in viewdata. this object 

Key: Is a String value to identify the object present in ViewData.
Value: Is the object present in ViewData. This object may be a String, object, list, array or a different type, such as int, char, float, double DateTime etc.

Note: ViewData does not provide compile time error checking. For Example- if you mis-spell keys you wouldn’t get any compile time errors. You get to know about the error only at runtime.
*/

//-----------------------------------
//HomeController


using Microsoft.AspNetCore.Mvc;

namespace LayOutPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Abdullah";
            ViewData["Age"] = 25;
            ViewData["Time"] = DateTime.Now.ToLongDateString();

            string[] name = { "Ali", "Asad" };
            ViewData["Names"] = name;

            ViewData["ListOfGames"] = new List<string>()
            {
                "Cricket", "Hockey" , "Soccer"
            };

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}


//---------------Access above viewData


@{
    ViewData["Title"] = "Index";
}

<h1>Index Page</h1>
<p>This is Index page</p>



@ViewData["Name"];
<br>
@ViewData["Age"];
<br>
@ViewData["Time"];

<br />

@{
    foreach (var item in  (string[])ViewData["Names"])
    {
        <h2>@item</h2>
    }
}

@{
    foreach (var item in (List<string>)ViewData["ListOfGames"])
    {
        <h2>@item</h2>
    }
}
