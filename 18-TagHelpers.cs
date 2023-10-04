//Tag helpers are like Html Action Link
//Before using tag helper we should add namespace in => ViewImports file 
//namespace is Microsoft.AspNetCore.Mvc.TagHelpers.
//@addTagHelper is a directive


/*
we add this line 

@addTagHelper*,
Microsoft.AspNetCore.Mvc.TagHelpers
*/

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


//_ViewImports.cshtml
@using TagHelperDemo
@using TagHelperDemo.Models
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers



//Index.cshtml

@{
    ViewData["Title"] = "Home Page";
}

<div class="text-center">
    <h1 class="display-4">Welcome</h1>
    <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
</div>

@* 
<a href="/Home/Contact">Click to go to Contact Page</a>
<br />
@* This below line will generate anchor *@
@Html.ActionLink("Click to go to Contact Page","Contact","Home"); 

<br />

@* This below line will generate Href not anchor *@
<a href="@Url.Action("Contact","Home")">Click to go to Contact Page</a>
<br />

@* -------------------------------------- *@
@* Now we will use Tag Helper --> See Below  *@

@* <a asp-controller="Home" asp-action="Contact">Click to go to Contact Page</a>  *@


@* ----------------------------------------------------- *@
@* ----------------------------------------------------- *@

@* We use Id Concept  *@
<a href="/Home/Contact/1">Click to go to Contact Page</a>
<br />

@Html.ActionLink("Click to go to Contact Page","Contact","Home", new {id =1});
<br />

<a href="@Url.Action("Contact","Home", new {id = 1})">Click to go to Contact Page</a>
<br />

@* -------------------------------------- *@
@* Now we will use Tag Helper --> See Below  *@

<a asp-controller="Home" asp-action="Contact" asp-route-id = "1">Click to go to Contact Page</a>