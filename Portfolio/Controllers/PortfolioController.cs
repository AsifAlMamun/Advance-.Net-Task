using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Home()
        {
            string name = "MD ASIF AL MAMUN";
            string email = "aasifalmamunrafi@gmail.com";
            string bio = "I am a fast learner";

            ViewBag.Name = name;
            ViewBag.Email = email;
            ViewBag.Bio = bio;
            return View();
        }
        public ActionResult ProfileControler()
        {
            MyProfile m1 = new MyProfile();
            m1.Name = "MD ASIF AL MAMUN";
            m1.Dob = "17.12.2000";
            m1.Nationality = "Bangladeshi";
            m1.BGroup = "A+";
            m1.Address = "Dhaka";
            m1.Contact = "017******34";
            m1.Hobbies = new string[] { "Playing Cricket", "Traveling","Cooking" };
            return View(m1);
        }

        public ActionResult Education()
        {
            MyEducation edu1 = new MyEducation();
            edu1.Degree = "BSc in CSE";
            edu1.Institution = "AIUB";
            edu1.Year = "2023";

            MyEducation edu2 = new MyEducation();
            edu2.Degree = "Hsc";
            edu2.Institution = "Rangpur lions School & College";
            edu2.Year = "2019";
            

            MyEducation edu3 = new MyEducation();
            edu3.Degree = "Ssc";
            edu3.Institution = "Palashbari SM Model High School";
            edu3.Year = "2017";
            
            



            MyEducation[] myEducations = new MyEducation[] { edu1, edu2, edu3 };

            ViewBag.Education = myEducations;

            return View();
        }

        public ActionResult Projects()
        {
            var p1 = new MyProject();
            p1.Course = "OOP1";
            p1.Description = "Restaurant Management System";

            var p2 = new MyProject();
            p2.Course = "WebTec";
            p2.Description = "Travel Management System";

            var p3 = new MyProject();
            p3.Course = "OOP2";
            p3.Description = "Bank Management System";

            var MyProjects = new MyProject[] { p1, p2, p3 };
            return View(MyProjects);
         
        }

        public ActionResult References()

        {
            ViewBag.Name1 = "James Marshall";
            ViewBag.Email1 = "marshall098@gmail.com";
            ViewBag.Name2 = "Dr. Jean Rodrygue";
            ViewBag.Email2 = "jean123@gmail.com";
            return View();
        }
    }
}