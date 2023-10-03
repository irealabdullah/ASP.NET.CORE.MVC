//Repository

//student trpository


using ModelsAspCore.Models;

namespace ModelsAspCore.Repository
    
{
    public class StudentRepository : IStudent
    {
        public List<Student> GetAllStudents()
        {
            return Datasource();
        }

        public Student GetStudentByID(int id)
        {
            return Datasource().Where(x => x.rollno == id).FirstOrDefault();
        }

        private List<Student> Datasource()
        {
            return new List<Student>
            {
            new Student() {rollno = 1, name = "Abdullah", Gender = "Male",standard = 5},
            new Student() {rollno = 2, name = "Ali", Gender = "Male",standard = 2},
            new Student() {rollno = 3, name = "Asad", Gender = "Male",standard = 3},
            new Student() {rollno = 4, name = "Sara", Gender = "Female",standard = 9},
            new Student() {rollno = 5, name = "Azam", Gender = "Male",standard = 3},
            };
                 
        }
    }
}

//IStudent 
using ModelsAspCore.Models;

namespace ModelsAspCore.Repository
{
    public interface IStudent
    {
        List<Student> GetAllStudents();
        Student GetStudentByID(int id);
    }
}


//Home Controller


using Microsoft.AspNetCore.Mvc;
using ModelsAspCore.Models;
using ModelsAspCore.Repository;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ModelsAspCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public  Student getByID(int id)
        {
            return _studentRepository.GetStudentByID(id);
        }
        public IActionResult Index()
        {
            //var students = new List<Student>()
            //{
            //    new Student()
            //    {
            //        rollno = 1, name = "Abdullah", Gender = "Male", standard = 5
            //    },
            //      new Student()
            //    {
            //        rollno = 2, name = "Ali", Gender = "Male", standard = 7
            //    },
            //        new Student()
            //    {
            //        rollno = 3, name = "Arfat", Gender = "Male", standard = 11
            //    }
            //};
            //ViewData["MyStudents"] = students;

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

// Model
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


