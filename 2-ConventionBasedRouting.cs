// These are all middlewares 

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting(); // used for routing 

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); //convention based routing 

app.Run();


//--------------------------------------------------------------

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // create link between view and controller
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.MapDefaultControllerRoute(); // call home controller and index method

app.MapControllerRoute( //We can also give naming convention
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
app.Run();


//--------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public int details(int id)
        {
            return id; 
        }
    }
}


//https//localhost:7077/Home/details/54