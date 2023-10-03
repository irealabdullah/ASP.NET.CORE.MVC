// Model
namespace ModelDataUsingVD.VB.TP.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public int EmpSalary{ get; set; }
    }
}

//Home Controller

using Microsoft.AspNetCore.Mvc;
using ModelDataUsingVD.VB.TP.Models;
using System.Diagnostics;

namespace ModelDataUsingVD.VB.TP.Controllers
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
            Employee Emp = new Employee()
            {
                EmpID = 101, EmpName = "Ali", EmpDesignation = "Manager", EmpSalary = 25000
            };

            //  ViewData["MyEmpVD"] = Emp;
            // ViewBag.MyEmpVB = Emp;
           // TempData["MyEmpTD"] = Emp;


            // I am going to make list of employees 
            var myEmployee = new List<Employee>
        {
            new Employee {EmpID = 1, EmpName = "Pream", EmpDesignation = "Manager", EmpSalary = 25000 },
            new Employee {EmpID = 2, EmpName = "Ali", EmpDesignation = "HR", EmpSalary = 6548 },
            new Employee {EmpID = 3, EmpName = "Osama", EmpDesignation = "ACCOUNTS", EmpSalary = 695 },
            new Employee {EmpID = 4, EmpName = "Rashid", EmpDesignation = "CA", EmpSalary = 5652 },
            new Employee {EmpID = 5, EmpName = "Soloman", EmpDesignation = "CLEARK", EmpSalary = 523 },
        };

            //ViewData["MyEmpVD"] = myEmployee;
            ViewBag.MyEmpVB = myEmployee;
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


// index.html

@{
    ViewData["Title"] = "Home Page";

    //var emp = ViewData["MyEmpVD"] as Employee; 
    //   var emp = ViewBag.MyEmpVB;
    // var emp = TempData["MyEmpTD"] as Employee;


    //var emps = ViewData["MyEmpVD"] as List<Employee>;
    var emps = ViewBag.MyEmpVB as List<Employee>;

}

<div class="text-center">
    <h1 class="display-4">Welcome</h1>
    <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
</div>

@{
    // if(emp != null)
    // {
    //     <h2>@emp.EmpID</h2>
    //     <h2>@emp.EmpName</h2>
    //     <h2>@emp.EmpDesignation</h2>
    //     <h2>@emp.EmpSalary</h2>
    // }

    // foreach (var item in emps)
    // {
    //     <h2>@item.EmpID</h2>
    //     <h2>@item.EmpName</h2>
    //     <h2>@item.EmpDesignation</h2>
    //     <h2>@item.EmpSalary</h2>
    //     <br />
    // }
 
    foreach (var item in emps)
    {
        <h2>@item.EmpID</h2>
            <h2>@item.EmpName</h2>
            <h2>@item.EmpDesignation</h2>
            <h2>@item.EmpSalary</h2>
            <br />
    }
}

