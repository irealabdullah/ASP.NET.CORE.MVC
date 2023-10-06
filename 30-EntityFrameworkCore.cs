

//read notes


//Home Controller

using CodeFirstAspCore6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeFirstAspCore6.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDbContext stdDB;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(StudentDbContext stdDB)
        {
            this.stdDB = stdDB;
        }
        public IActionResult Index()
        {
            var stdData = stdDB.Students.ToList();
            return View(stdData);
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



//index.cshtml

@model IEnumerable<CodeFirstAspCore6.Models.Student>

@{
    ViewData["Title"] = "Index";
}

<h1>Index</h1>

<p>
    <a asp-action="Create">Create New</a>
</p>
<table class="table">
    <thead>
        <tr>
            <th>
                @Html.DisplayNameFor(model => model.StudentName)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.StudentGender)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.StudentAge)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Standard)
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
@foreach (var item in Model) {
        <tr>
            <td>
                @Html.DisplayFor(modelItem => item.StudentName)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.StudentGender)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.StudentAge)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Standard)
            </td>
            <td>
                <a asp-action="Edit" asp-route-id="@item.StudentID">Edit</a> |
                <a asp-action="Details" asp-route-id="@item.StudentID">Details</a> |
                <a asp-action="Delete" asp-route-id="@item.StudentID">Delete</a>
            </td>
        </tr>
}
    </tbody>
</table>


//model

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstAspCore6.Models
{
    public class Student
    {
        [Key]  //Primary key
        public int StudentID { get; set; }
        [Column("StudentName",TypeName ="varchar(100)")] //Table main column ka name "Student Name" hoo ga
        public String StudentName{ get; set; }
        
        [Column("StudentGender", TypeName = "varchar(100)")] 
        public String StudentGender{ get; set; }

     //   [Column("SudentAge", TypeName = "int(20)")]
        public int StudentAge { get; set; }

        public int Standard{ get; set; }
    }
}


//studentDbcontext.cs



using Microsoft.EntityFrameworkCore;

namespace CodeFirstAspCore6.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        } 
     public DbSet<Student> Students { get; set; }  //Database table ka name Students hoo ga jo humne yahaan rakha hai 
    }
}


//appsetting.json

{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "dbcs": "Server=ABDULLAH;Database=CodeFirstDB;Trusted_Connection=True;"
  },
  "AllowedHosts": "*"
}




//program.cs

using CodeFirstAspCore6.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var provider = builder.Services.BuildServiceProvider(); //
var config = provider.GetRequiredService<IConfiguration>(); //
builder.Services.AddDbContext<StudentDbContext>(item => item.UseSqlServer(config.GetConnectionString("dbcs"))); //

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



