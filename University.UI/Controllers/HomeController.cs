using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.Domain.Entities;
using University.Infrastructure.DataAccess;
using University.Services.Concrete;

namespace University.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserService<Student> svc;
        public HomeController()
        {
            svc = new UserService<Student>();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(Student std)
        {
           svc.Add(std);
            return View();
        }

        public ActionResult GetStudents()
        {
            var students = svc.GetAll();
            ViewBag.Students = students;
            return View();

        }
    }
}