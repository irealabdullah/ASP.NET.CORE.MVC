/*
1. we will bind our form with model
2. form will use datatype of model
3. asp-for tag helper is used as an <input> 
*/

//Model 
namespace ImageTagHelper.Models
{
    public class Employee
    {
        public string EmpName { get; set; }
        public string EmpAge { get; set; }
        public string EmpDesignation { get; set; }
        public string EmpSalary { get; set; }
    }
}


//index.cshtml
@model ImageTagHelper.Models.Employee;
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
            <form  asp-action="Index" asp-controller="Home" method="post"> 
                <input asp-for="EmpName" placeholder="Enter Name" class="form-control"/> 
                <br /> 
                <input asp-for="EmpAge" placeholder="Enter Age" class="form-control" /> 
                <br />
                <input asp-for="EmpDesignation" placeholder="Enter Designation" class="form-control" /> 
                <br />
                <input asp-for="EmpSalary" placeholder="Enter Salary" class="form-control"/>
                <br />
                <input type="submit" value="Submit" class="btn btn-outline-primary  "/>

            </form>
        </div>

    </div>
</div>