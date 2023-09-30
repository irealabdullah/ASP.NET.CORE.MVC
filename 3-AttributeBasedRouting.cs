// Program.cs

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();  //Attribute Based Routing 
var app = builder.Build();


app.MapControllers();  //Attribute Based Routing 
app.Run();

// -----------------------------------------


using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]  // Route Empty Hooga tu index method chale ga 
        [Route("Home")] // Route Empty Hooga tu index method chale ga 
        [Route("Home/Index")] // Route Empty Hooga tu index method chale ga 

        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/About")]   // This is called Attribute Based routing 
        public IActionResult About()
        {
            return View();
        }

        [Route("Home/details/{id?}")]
        public int details(int? id)
        {
            return id ?? 20; 
        }
    }
}


// -----------------------------------------


using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    [Route("Home")]  // ham ne controller ke upper route define kardia hai 
    // ab zaida asani hoo gayi hai 
    // yeh Home neech index, about, details sab ke sath concatanate hoo ga ;)  

    public class HomeController : Controller
    {
        [Route("")]  
        [Route("Index")] 
        [Route("~/")]  // Route hamara khali hai but yeh masla solve kardee ga 

        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("details/{id?}")]
        public int details(int? id)
        {
            return id ?? 1; 
        }
    }
}


//----------------------------------------------------

// ab yahan par controller ka name change hoo jaye ga uss controller name se jo ham ne define kia hoo ga 
// same action method ka name replace hoo jaye ga action se 
using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    //We can also pass tokens 
    [Route("[Controller]")]
    public class HomeController : Controller
    {
        [Route("")]  
        [Route("[action]")] 
        [Route("~/")]  

        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }

        [Route("[action]/{id?}")]
        public int details(int? id)
        {
            return id ?? 1; 
        }
    }
}

//------------------------------------------------------

using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    //We can also pass tokens 
    [Route("[Controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("")]  
        [Route("~/")]  
        [Route("~/Home")]  // This is when we define only controller name 
        // Agr hum yeh upper wali line nah likhain tu url main jab hum controller ka name likhain ge tu kuch display nahi hoo ga ;) 
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [Route("{id?}")]
        public int details(int? id)
        {
            return id ?? 1; 
        }
    }
}

