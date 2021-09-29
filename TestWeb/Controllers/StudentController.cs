using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWeb.Models;

namespace TestWeb.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Attendance(string id)
        {
            ViewBag.StudentName = id;
            return View();
        }

        public IActionResult Create(Student s)
        {
            s.StudentName = "Yumna";
            s.FatherName = "Zahid";
            return View(s);
        }

        public IActionResult Save(Student s)
        {

            Student.StudentList.Add(s);

            return View("List",Student.StudentList);
        }
    }
}
