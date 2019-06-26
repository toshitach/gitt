using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using BOL;
using DAL;

namespace crudfrontend.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            string msg = "student list";
            List<Student> students = new List<Student>();
            students = StudentManager.GetAll();

            //RepoManager.GetAllProducts();
            ViewData["students"] = students;
            return View();
        }
    }
}