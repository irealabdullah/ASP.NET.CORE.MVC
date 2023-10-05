// model

using System.ComponentModel.DataAnnotations;

namespace ValidationAttributes.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please Enter Name")] // Field cannot be null 
        [StringLength(15,MinimumLength = 3,ErrorMessage = "Enter Character between 3-15")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [EmailAddress] // adil prefer regular expression 
        public string Email { get; set; }

        [Required(ErrorMessage ="Please Enter Integer number ;)")]
        [Range(18,30,ErrorMessage ="Sahi Age daal bhai")]
        public int? Age { get; set; }
    }
}


//index.cshtml

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

    <input asp-for="Email" class="form-control" placeholder="Enter Email"/>
    <span asp-validation-for="Email" style="color:red"></span>
    <br />
    <input asp-for="Age" class="form-control" placeholder="Enter Age"/>
    <span asp-validation-for="Age" style="color:red"></span>


                <br />

    <input type="submit" value="Submit" class="btn btn-outline-primary"/>
</form>
        </div>
    </div>

</div>