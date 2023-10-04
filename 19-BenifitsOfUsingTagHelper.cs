//index.cshtml

@{
    ViewData["Title"] = "Home Page";
}

<div class="text-center">
    <h1 class="display-4">Welcome</h1>
    <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
</div>

// @* view page source code *@
// @* ab yeh kaam nahi kare ga *@
// @* only this link will not work ;)  *@
<a href="/Home/Contact">Click to go to Contact Page</a> 
<br />

// @* This will work and it will show your company name you mention in program.cs file --> That is benifit of Tag Helper*@
<a asp-controller="Home" asp-action="Contact">Click to go to Contact Page</a> 
//@* only use tag helper and leave old school ;) *@


//@* -------------------------------- *@
<br />
//@* It will also work with these two below  *@
@Html.ActionLink("Click to go to Contact Page","Contact","Home");
<br />
<a href="@Url.Action("Contact","Home")">Click to go to Contact Page</a>
<br />

//HomeController
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TagHelperDemo.Models;

namespace TagHelperDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")] //see index.cshtml
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

//Program.cs 


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
//Suppose hamain apni company ka name show karwana hai URL main 

//main kisi bhi controller main chala jaon mujhe apni company ka name = ABC show hoo ga 
// abhi nahi chale ga because we made changes in convention based routing 
// chalane ke liye we must use attribute base routing in home controller
app.MapControllerRoute(
    name: "default",
    pattern: "ABC/{controller=Home}/{action=Index}/{id?}");

app.Run();


//_ViewImports.cshtml
//add this tag helper in _ViewImports.cshtml
@using TagHelperDemo
@using TagHelperDemo.Models
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
