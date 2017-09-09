using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KelolaPegawai.Controllers
{
    public class MetroController : Controller
    {
        // GET: Metro
        public ActionResult Index()
        {
            return View();
        }
        // GET: Metro/UI
        public ActionResult UI()
        {
            return View();
        }
        // GET: Metro/Forms
        public ActionResult Forms()
        {
            return View();
        }
        // GET: Metro/Charts
        public ActionResult Charts()
        {
            return View();
        }
        // GET: Metro/Tables
        public ActionResult Tables()
        {
            return View();
        }
    }
}