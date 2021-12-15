using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowTeacher()
        {
            ViewBag.TeacherName = "yakov";
            return View();
        }
        public ActionResult ShowAllTeachers()
        {
            ViewBag.AllTeachersName = new string[] { "shlomo", "aschalow", "yakov", "morit", "asaf", "takla" };
            return View();
        }
        public ActionResult TenRandomNumbers()
        {
            ViewBag.arrayNames = new int[10];

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                ViewBag.arrayNames[i] = random.Next(1, 10);
            }
            return View();
        }

        public ActionResult ShowNameLongerThan4()
        {
            ViewBag.famaliyNames = new string[] { "hailu", "levi", "choen", "shalom", "asaf", "takla","yosef","eyal","lolo","shoko" };
            return View();
        }
        public ActionResult ClassTeacher()
        {
            Teacher teacher1 = new Teacher("yosef", "choen", 1970, 40);
            ViewBag.TeacherClass = teacher1;
            return View();
        }
        public ActionResult ClassTeacherWithModel()
        {
            Teacher teacher2 = new Teacher("yosef", "lior", 1980, 42);
            return View(teacher2);

        }
        public ActionResult ClassDirector()
        {
            Director director1 = new Director("dan", "levi", "0543812");
            ViewBag.DirectorClass = director1;
            return View();
        }
        public ActionResult ClassDirectorWithModel()
        {
            Director director2 = new Director("avi", "shalom", "0542222");
            return View(director2);
            
        }
        //public ActionResult buttonToTeacher()
        //{
            
        //    return View();
        //}
    }

}