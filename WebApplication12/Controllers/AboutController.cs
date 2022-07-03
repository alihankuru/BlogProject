using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication12.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManager abm = new AboutManager();
        public ActionResult Index()
        {
            var aboutcontent = abm.GetAll();

            return View(aboutcontent);
        } 
        
        public PartialViewResult Footer()
        {
            var x = abm.GetAll();

            return PartialView(x);
        }

        [HttpGet]
        public ActionResult UpdateAboutList()
        {
            var aboutlist = abm.GetAll();

            return View(aboutlist);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            abm.UpdateAboutBM(p);

            return RedirectToAction("UpdateAboutList");


        }

    }
}