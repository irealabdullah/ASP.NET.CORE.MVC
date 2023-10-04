//Home Controller

using HowToAddModelsInEveryView.Models;
using Microsoft.AspNetCore.Mvc;

namespace HowToAddModelsInEveryView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<Student> students = new List<Student>
        {
            new Student {StdID = 1, StdName = "Pream", StdGender = "male"},
            new Student {StdID = 2, StdName = "Ali", StdGender = "male"},
            new Student {StdID = 3, StdName = "Osama", StdGender = "male"},
            
        };
            return View(students);
        }

        public IActionResult About()
        {

            List<Student> students = new List<Student>
        {
            new Student {StdID = 1, StdName = "Pream", StdGender = "male"},
            new Student {StdID = 2, StdName = "Ali", StdGender = "male"},
            new Student {StdID = 3, StdName = "Osama", StdGender = "male"},

        };
            return View(students);
        }

        public IActionResult Contact()
        {

            List<Student> students = new List<Student>
        {
            new Student {StdID = 1, StdName = "Pream", StdGender = "male"},
            new Student {StdID = 2, StdName = "Ali", StdGender = "male"},
            new Student {StdID = 3, StdName = "Osama", StdGender = "male"},

        };
            return View(students);
        }
    }
}


//models

namespace HowToAddModelsInEveryView.Models
{
    public class Student
    {
        public int StdID { get; set; }
        public string StdName { get; set; }
        public string StdGender{ get; set; }
    }
}


//index

//@* @model List<HowToAddModelsInEveryView.Models.Student> // i have to use this in all views, this is not a good practice *@
@model List<Student>
@{
    ViewData["Title"] = "Index";
}

<h1>Index</h1>

@{
    foreach (var item in Model)
    {
        <h2>@item.StdID</h2>
        <h2>@item.StdName</h2>
        <h2>@item.StdGender</h2>

        <br />
    }
}



//contact

//@* @model List<HowToAddModelsInEveryView.Models.Student> // i have to use this in all views, this is not a good practice *@
@model List<Student> // i have to use this in all views, this is not a good practice

@{
    ViewData["Title"] = "Contact";
}

<h1>Contact</h1>



@{
    foreach (var item in Model)
    {
        <h2>@item.StdID</h2>
        <h2>@item.StdName</h2>
        <h2>@item.StdGender</h2>

        <br />
    }
}


//About

//@* @model List<HowToAddModelsInEveryView.Models.Student>  // i have to use this in all views, this is not a good practice *@
@model List<Student>
@{
    ViewData["Title"] = "About";
}

<h1>About</h1>



@{
    foreach (var item in Model)
    {
        <h2>@item.StdID</h2>
        <h2>@item.StdName</h2>
        <h2>@item.StdGender</h2>

        <br />
    }
}


//_ViewImport.cshtml

// we make this file in view and =>> add =>> search Razor ==> add => _ViewImport.cshtml

@using HowToAddModelsInEveryView.Models; //IMPORT NAMESPACE IN INDEX , ABOUT, CONTACT





/*
_ViewImport.cshtml file supports the following directives: 

@addTagHelper
@tagHelperPrefix
@removeTagHelper
@namespace
@inject
@model
@using
*/