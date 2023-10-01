//Models


namespace ModelsAspCore.Models
{
    public class Student
    {

        public int rollno { get; set; }
        public string name { get; set; }
        public string Gender { get; set; }
        public int standard { get; set; }

    }
}


//---------------------

//Controller

using Microsoft.AspNetCore.Mvc;
using ModelsAspCore.Models;
using System.Diagnostics;

namespace ModelsAspCore.Controllers
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

            var students = new List<Student>()
            {
                new Student()
                {
                    rollno = 1, name = "Abdullah", Gender = "Male", standard = 5
                },
                  new Student()
                {
                    rollno = 2, name = "Ali", Gender = "Male", standard = 7
                },
                    new Student()
                {
                    rollno = 3, name = "Arfat", Gender = "Male", standard = 11
                }


            };

            ViewData["MyStudents"] = students;

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




//---------------------

//View

@{
    ViewData["Title"] = "Home Page";

    var students = ViewData["MyStudents"] as List<Student>;

    
}

<div class="text-center">
    <h1 class="display-4">Welcome</h1>
    <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
</div>

<table>
    <tr>
        <th>Roll No</th>
        <th>Name</th>
        <th>Gender</th>
        <th>Class</th>
    </tr>

    @foreach (var std in students)
    {
        <tr>
            <td>@std.rollno</td>
            <td>@std.name</td>
            <td>@std.Gender</td>
            <td>@std.standard</td>

        </tr>
    }


</table>


