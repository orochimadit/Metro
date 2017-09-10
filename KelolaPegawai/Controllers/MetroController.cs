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
        public ActionResult Latihan()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Latihan(string TextBoxNama, string TextAreaAlamat, string DropDownListPropinsi, string RadioButtonJenisKelamin, bool CheckBoxBahasaCSharp, bool CheckBoxBahasaJava, bool CheckBoxBahasaPhyton, IEnumerable<string> ListBoxPekerjaan)
        {
            string languages = String.Empty; string jobs = String.Empty;
            if (CheckBoxBahasaCSharp) { languages = "C#" + " " + languages; }
            if (CheckBoxBahasaJava) { languages = "Java" + " " + languages; }


            if (CheckBoxBahasaPhyton) { languages = "Phyton" + " " + languages; }
            foreach (string job in ListBoxPekerjaan) { if (job.Equals("1")) { jobs = "Programmer " + jobs; } else if (job.Equals("2")) { jobs = "Analis Sistem " + jobs; } else if (job.Equals("3")) { jobs = "Administrator Database " + jobs; } else { jobs = "Manajer Proyek " + jobs; } }
            ViewBag.Hasil = TextBoxNama + " " + TextAreaAlamat + " " + DropDownListPropinsi + " " + RadioButtonJenisKelamin + " " + languages + " " + jobs; return View();
        }
        
    }
}