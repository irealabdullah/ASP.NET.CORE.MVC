/*
	ViewBag is also used to transfer data from a controller to a view.
	ViewBag exists only for the current request and becomes null if the request is redirected.
	ViewBag is a dynamic property based on the dynamic features introduced in C# 4.0.
	ViewBag does not require typecasting when you use complex data type.
The general syntax of ViewBag is as follows:
ViewBag.<PropertyName> = <Value>;
where,
Property: Is a String value that represents a property of ViewBag.
Value: Is the value of the property of ViewBag, Value may be a String, object, list, array or a different type, such as int, char, float, double DateTime etc.
Note: ViewBag does not provide compile time error checking. For Example- if you mis-spell keys you wouldn’t get any compile time errors. You get to know about the error only at runtime.
•	ViewData and ViewBag can access each other data interchangeably.
*/


using Microsoft.AspNetCore.Mvc;

namespace LayOutPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ViewData["Access"] = "Access Me from ViewBag"; // we can access this from viewBag too
            ViewBag.AccessMe = "Access Me from ViewData"; // we can access this from viewData too


            ViewBag.Name = "Abdullah";
            ViewBag.Age = 25;
            ViewBag.Time = DateTime.Now.ToLongDateString();

            string[] name = { "Ali", "Asad" };
            ViewBag.Names = name;

            ViewBag.Games = new List<string>()
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


// ------------------------------

@{
    ViewData["Title"] = "Index";
} 

<h1>Index Page</h1>
<p>This is Index page</p>


@ViewBag.Access <br /> 
@ViewData["AccessMe"]
<br />


@ViewBag.Name;
<br>
@ViewBag.Age;
<br>
@ViewBag.Time;

<br />

@{
    foreach (var item in ViewBag.Names)
    {
        <h2>@item</h2>
    }
}

@{
    foreach (var item in ViewBag.Games)
    {
        <h2>@item</h2>
    }
}
