//Home Controller

using Microsoft.AspNetCore.Mvc;
using StronglyTypedViews.Models;
using System.Diagnostics;

namespace StronglyTypedViews.Controllers
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
            //Employee obj = new Employee()
            //{ EmpID = 101, EmpName = "Abdullah", EmpSalary = 25000, EmpDesignation = "Manager" };

            var myEmployee = new List<Employee>
        {
            new Employee {EmpID = 1, EmpName = "Pream", EmpDesignation = "Manager", EmpSalary = 25000 },
            new Employee {EmpID = 2, EmpName = "Ali", EmpDesignation = "HR", EmpSalary = 6548 },
            new Employee {EmpID = 3, EmpName = "Osama", EmpDesignation = "ACCOUNTS", EmpSalary = 695 },
            new Employee {EmpID = 4, EmpName = "Rashid", EmpDesignation = "CA", EmpSalary = 5652 },
            new Employee {EmpID = 5, EmpName = "Soloman", EmpDesignation = "CLEARK", EmpSalary = 523 },
        };
            return View(myEmployee);
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


//index.cshtml


@* @model StronglyTypedViews.Models.Employee //single object  *@

@* @model List<StronglyTypedViews.Models.Employee> //Either this way  *@

@model IEnumerable<StronglyTypedViews.Models.Employee> // or this
@{
    ViewData["Title"] = "Home Page";
  
}

<div class="text-center">
    <h1 class="display-4">Welcome</h1>
    <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
</div>


@* <h2>@Model.EmpID</h2>
<h2>@Model.EmpName</h2>
<h2>@Model.EmpSalary</h2>
<h2>@Model.EmpDesignation</h2>
 *@

 
 @{
     foreach (var item in Model)
    {
        <h2>@item.EmpID</h2>
        <h2>@item.EmpName</h2>
        <h2>@item.EmpSalary</h2>
        <h2>@item.EmpDesignation</h2>

        <br />
    }
 }


 //model

 namespace StronglyTypedViews.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public String EmpName { get; set; }
        public String EmpDesignation { get; set; }
        public int EmpSalary { get; set; }
    }
}
