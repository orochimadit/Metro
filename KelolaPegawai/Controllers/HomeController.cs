using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KelolaPegawai.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //get:login 
        public ActionResult Login() {
            return View();
        }

        //POST: LOGIN 
        /*[HttpPost]
        public ActionResult Login(LoginViewModel data) {
            return View();
        }*/

        //Get:PageNotFound
        public ActionResult PageNotFound() {
            return View();
        }
        
    }
}