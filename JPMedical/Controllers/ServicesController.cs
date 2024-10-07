using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JPMedical.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Angioplasty_Services()
        {
            return View();
        }
        public ActionResult Cardiology_Services()
        {
            return View();
        }
        public ActionResult Dental_Services()
        {
            return View();
        }
        public ActionResult Endocrinology_Services()
        {
            return View();
        }
        public ActionResult Eye_Care_Services()
        {
            return View();
        }
        public ActionResult Nurology_Service()
        {
            return View();
        }
        public ActionResult Orthopaedics_Services()
        {
            return View();
        }
        public ActionResult Rmi_Services()
        {
            return View();
        }
    }
}