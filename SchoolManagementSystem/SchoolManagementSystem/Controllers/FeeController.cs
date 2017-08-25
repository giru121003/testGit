using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controllers
{
    public class FeeController : Controller
    {
        StudentContext sc = new StudentContext();
        // GET: Fee
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(StudentFee stufee)
        {
            if (ModelState.IsValid)
            {
                sc.StudentFees.Add(stufee);
                sc.SaveChanges();
               
                RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public ActionResult SelectFee()
        {
            ViewBag.stndrd = sc.StudentFees;
            return View();
        }
    }
}