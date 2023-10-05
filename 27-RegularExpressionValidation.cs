//regular expression 
// user password dalta hai aur password agar weak hai tu usko show hoo jaye ga 


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

    <input asp-for="Email" class="form-control" placeholder="Enter Email"/>
    <span asp-validation-for="Email" style="color:red"></span>
    <br />
    <input asp-for="Age" class="form-control" placeholder="Enter Age"/>
    <span asp-validation-for="Age" style="color:red"></span>
    <br />
    

    <input asp-for="password" class="form-control" placeholder="Enter Password"/>
    <span asp-validation-for="password" style="color:red"></span>

                <br />

                <input asp-for="PakiNumber" class="form-control" placeholder="Enter Contact" />
                <span asp-validation-for="PakiNumber" style="color:red"></span>

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

        [Required(ErrorMessage ="Email is required")]
        //[EmailAddress] // adil prefer regular expression 
        [RegularExpression("^([0-9a-zA-Z]([-\\\\.\\\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\\\w]*[0-9a-zA-Z]\\\\.)+[a-zA-Z]{2,9})$\r\n",ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please Enter Integer number ;)")]
        [Range(18,30,ErrorMessage ="Sahi Age daal bhai")]
        public int? Age { get; set; }

        [RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$",ErrorMessage ="Uppercase, Lowercase, symbols")] //find from internet 
        public string password { get; set; }

        [Required(ErrorMessage = "Please Enter Correct number ;)")]
        [RegularExpression("^((\\+92)|(0092))-{0,1}\\d{3}-{0,1}\\d{7}$|^\\d{11}$|^\\d{4}-\\d{7}$")] 

        public string PakiNumber{ get; set; }

    }
}
