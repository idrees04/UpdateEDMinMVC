using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpdateEDMinMVC.Models;

namespace UpdateEDMinMVC.Controllers
{
    public class HomeController : Controller
    {
        EDMExampleMVCEntities db = new EDMExampleMVCEntities();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.students.ToList();

            return View(data);
        }

        public ActionResult Employee()
        {
            var data = db.employees.ToList();

            return View(data);
        }
    }
}