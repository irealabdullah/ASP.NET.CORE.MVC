//models

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
                <select asp-for="Gender" class="form-control" asp-items="Html.GetEnumSelectList<Gender>()">
                    <option value="">Select Gender</option>
                </select>
                <br />
                <input asp-for="EmpAge" placeholder="Enter Age" class="form-control" /> 
                <br />
                <input asp-for="EmpDesignation" placeholder="Enter Designation" class="form-control" /> 
                <br />
                <input asp-for="EmpSalary" placeholder="Enter Salary" class="form-control"/>
                <br />
                
                <label>
                    Married:
                </label>

                    <div class="form-check">
                        <input class="form-check-input" type="radio" asp-for="Married" value="Yes">
                        <label class="form-check-label" for="flexRadioDefault1">
                            Yes
                        </label>
                    </div>

                    <div class="form-check">
                        <input class="form-check-input" type="radio" asp-for="Married" value="No">
                        <label class="form-check-label" for="flexRadioDefault2">
                            No
                        </label>
                    </div>
                <br />

                <textarea asp-for="Description" class="form-control" placeholder="Enter Description" rows="5">

                </textarea>
                <br />
                <input type="submit" value="Submit" class="btn btn-outline-primary  "/>
            </form>
        </div>

    </div>
</div>

