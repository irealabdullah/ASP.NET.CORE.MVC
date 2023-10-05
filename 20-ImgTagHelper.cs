// _ViewImports.cshtml

@using ImageTagHelper
@using ImageTagHelper.Models
//Step#1 we must add this File Below 
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers 


// program.cs
app.UseStaticFiles();  //Step#2 we must use this middleware

//index.cshtml

@{
    ViewData["Title"] = "Home Page";
}

<div class="text-center">
    <h1 class="display-4">Welcome</h1>
    <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
</div>


//<img src="~/images/linux.png" height="400" width="400" alt="This is Linux images"/> 

 <img src="~/images/linux.png" asp-append-version="true" height="400" width="400" alt="This is Linux images"/> 


 //we can disable cache memory from developer tools => Network

 //if we change our image path, image will be downloaded from server that is use of img tag helper