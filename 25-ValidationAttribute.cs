//HomeController.cs

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ValidationAttributes.Models;

namespace ValidationAttributes.Controllers
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

        [HttpPost]
        public IActionResult Index(Student std)
        {
            return View();


            //-----------------------------------------------
            //if (ModelState.IsValid) 
            //{
            //    return "Name is " + std.Name;
            //}
            //else
            //{
            //    return "Validation Failed...";
            //}
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


// index.cshtml

@model ValidationAttributes.Models.Student;
@{
    ViewData["Title"] = "Home Page";
}

<div class="text-center">
    <h1 class="display-4">Welcome</h1>
    <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
</div>



<div class="container">
    <div class="row">
        <div class="col-sm-4">
<form asp-controller="Home" asp-action="Index" method="post">
    <input asp-for="Name" class="form-control" placeholder="Enter Name"/>
    <span asp-validation-for="Name" style="color:red"></span>
    <br />

    <input type="submit" value="Submit" class="btn btn-outline-primary"/>
</form>
        </div>
    </div>

</div>


//model

using System.ComponentModel.DataAnnotations;

namespace ValidationAttributes.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please Enter Name")] // Field cannot be null 
        [StringLength(15,MinimumLength = 3,ErrorMessage = "Enter Character between 3-15")]
        public string Name { get; set; }
        
    }
}
