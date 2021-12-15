using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PupilController : Controller
    {
        // GET: Pupil
        public ActionResult Index()
        {
            ViewBag.Name = "keren";
            return View();
        }
        public ActionResult ShowPupil()
        {
            ViewBag.NamePupil = "keren";
            return View();
        }
        public ActionResult ShowNamesPupils()
        {
            ViewBag.arrayNames=new string[] { "lior","dan","yaron","shlomi","shilat","avi"};
            return View();
        }
        public ActionResult ShowAllPupils()
        {
            ViewBag.arrayNames = new string[] { "lior", "dan", "yaron", "shlomi", "shilat", "avi" };
            return View();
        }

        public ActionResult ReturnArrayInJson()
        {
            string[] arrayToJson= new string[] { "lior", "dan", "yaron", "shlomi", "shilat", "avi" };
            return Json(arrayToJson, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ClassPupil()
        {
            Pupil pupil1 = new Pupil("keren", "hailu", 1998, 5);
            ViewBag.classPupil=pupil1;
            return View();
        }
        public ActionResult ClassPupilWithModel()
        {
            //Pupil pupil2 = newObj();
            //return View(pupil2);
            return View(newObj());
        }

        private static Pupil newObj()
        {
            return new Pupil("tikva", "yosef", 1996, 6);
        }

        public ActionResult ListPupil()
        {
            //List<Pupil> pupils = NewMethod();
            //return View(pupils);
            return View(NewMethod());

        }

        private static List<Pupil> NewMethod()
        {
            Pupil pupilOne = new Pupil("tikva", "yosef", 1996, 6);
            Pupil pupilTwo = new Pupil("keren", "hailu", 1998, 8);
            Pupil pupilThree = new Pupil("eden", "genet", 1997, 7);
            Pupil pupilFour = new Pupil("yafit", "smuel", 1999, 5);
            List<Pupil> pupils = new List<Pupil>();
            pupils.Add(pupilOne);
            pupils.Add(pupilTwo);
            pupils.Add(pupilThree);
            pupils.Add(pupilFour);
            return pupils;
        }
    }
}
