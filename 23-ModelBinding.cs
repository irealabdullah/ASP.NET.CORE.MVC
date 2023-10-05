/*
1. model binding is used to bind data from http requests(URL) to action method parameter

Example#1

student -> controller
edit -> action method
2 -> parameter

parameters can be of simple type string, integer, double  and complex type like student, employee, customer

Student/Edit/2  [This is Http Request or URL] 

This Below is Action Method Parameter 

public IActionResult Edit(int id)
{
    return View();
} 

so to Bind http Request with Action method parameter we use concept called model Binding 

Http Request <--> Model Binding <--> Action Method Parameter
---------------------------------------------------------------------------------------------

URL <--> ROUTING  <--> MODEL BINDING  <--> ACTION METHOD PARAMETER 
*/


//https://localhost:7060/home/Details/30?name=Abdullah

//This data can come from FORM 


//------------------------------------------------------------

//first root data execute than query string executes

https://localhost:7060/home/Details/30?name=Abdullah&id=7


//This below is query string 
https://localhost:7060/home/Details?name=Abdullah&id=7  

using Microsoft.AspNetCore.Mvc;
using ModelBindingAspCore.Models;
using System.Diagnostics;

namespace ModelBindingAspCore.Controllers
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

        public string Details(int id,string name)
        {
            return "ID is "+ id + " Name is: "+ name;
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


// -------------------------------------------------------------
//if we want to bind form with model class then 


//Controller

using ImageTagHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ImageTagHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //This works for get request 
        // jab ham apni application start kare ge tu yeh wala action method chale ha aur jab hum apna form submit karain ge tu uske neeche wala action method chale ga 
        public IActionResult Index()
        {
            return View();
        }

        // we will use this attribute
        //form submission will be handle by this 
        [HttpPost]
        public string Index(Employee e)
        {
            return "Name: " + e.EmpName + " Age: " + e.EmpAge + " Gender: " + e.Gender + " Salary: " + e.EmpSalary + " Designation: " + e.EmpDesignation;
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


//model.cs
namespace ImageTagHelper.Models
{
    public class Employee
    {
        public string EmpName { get; set; }
        public Gender Gender { get; set; }
        public string EmpAge { get; set; }
        public string EmpDesignation { get; set; }
        public string EmpSalary { get; set; }
        public string Married { get; set; }
        public string Description { get; set; }
    }

    public enum Gender 
    { 
        Male, Female
    }
}

//How model binding works 
/*
1. Form Values --> these are form values that go in http request using post methods
2. Route Values  --> these set of route values provided by routing
3. Query Strings  --> The query string part of the URL

NOTE: FORM VALUES, ROUTE DATA AND QUERY STRINGS ARE ALL STORED AS NAME-VALUE PAIRS
*/