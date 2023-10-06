// model

using System.ComponentModel.DataAnnotations;

namespace ValidationAttributes.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please Enter Name")] // Field cannot be null 
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Enter Character between 3-15")]
        [MinLength(15,ErrorMessage ="Min length = 15")]
        [MaxLength(30)]
        public string Name { get; set; }

       

        [Required(ErrorMessage = "Please Correct Password ;)")]
        [RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$",ErrorMessage ="Uppercase, Lowercase, symbols")] //find from internet 
        public string password { get; set; }
       


        [Required(ErrorMessage = "Please Correct Password")]
        [Compare("password",ErrorMessage ="Password Doesnot Match")]
        [Display(Name="Enter Confirm Password:")] //ab property ka name show nahi hoo ga 
        public string Confirmpassword { get; set; }


        [Required(ErrorMessage = "Please Enter Correct number ;)")]
        [RegularExpression("^((\\+92)|(0092))-{0,1}\\d{3}-{0,1}\\d{7}$|^\\d{11}$|^\\d{4}-\\d{7}$")] 
        public string PakiNumber{ get; set; }


        [Required(ErrorMessage ="Website URL is Must")]
        [Url]
        public string WebsiteURL { get; set; }

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
        

    <input asp-for="password" class="form-control" placeholder="Enter Password"/>
    <span asp-validation-for="password" style="color:red"></span>

    <br />
    <label asp-for="Confirmpassword"></label> @* ab property ka name show nahi hoo ga *@
    <input asp-for="Confirmpassword" class="form-control" placeholder="Enter Confirm Password" />
    <span asp-validation-for="Confirmpassword" style="color:red"></span>

    <br />

    <input asp-for="PakiNumber" class="form-control" placeholder="Enter Contact" />
    <span asp-validation-for="PakiNumber" style="color:red"></span>

    <br />

    <input asp-for="WebsiteURL" class="form-control" placeholder="Enter Website URL"/>
    <span asp-validation-for="WebsiteURL" style="color:red"></span>

    <br />
    <input type="submit" value="Submit" class="btn btn-outline-primary"/>


</form>
        </div>
    </div>

</div>