using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManagementSystem.Models;
using System.Data.Sql;
using System.Data.Entity;
namespace SchoolManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        StudentContext sc = new StudentContext();

        public ActionResult Index()
        {
            return RedirectToAction("ShowData");
        }
        public ActionResult ShowData()
        {
            var slist = sc.Students.Include("Standard").ToList();
            var items = slist.Select(r => new StudentStandard
            {
                Id = r.Id,
                First = r.FirstName,
                Last = r.LastName,
                Phone=r.PhoneNumber,
                DOB=r.DateofBirth,
                Standardname = r.standard.StandardName
            }).ToList();

            return View(items);
        }
        [HttpGet]
        public ActionResult Create()
        {
           ViewBag.stndrd= sc.Standards;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student stu)
        {
            if (ModelState.IsValid)
            {
                sc.Students.Add(stu);
                sc.SaveChanges();
               return RedirectToAction("ShowData");
            }
            else
            {
                ViewBag.stndrd = sc.Standards;
                return View();
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var std = sc.Students.Where(s => s.Id == id).FirstOrDefault();
            ViewBag.stndrd = sc.Standards;
            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student stu)
        {
            if (ModelState.IsValid)
            {
                sc.Entry(stu).State = EntityState.Modified;
                sc.SaveChanges();
                return RedirectToAction("ShowData");
            }
            ViewBag.stndrd = sc.Standards;
            return View(stu);
        }
        public ActionResult Delete(int id)
        {
            Student stu = sc.Students.Find(id);
            sc.Students.Remove(stu);
            sc.SaveChanges();
            return RedirectToAction("ShowData");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Founded in 1995 by Rama Devi(MD)  ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Add()
        {
            return View("~/Views/Fee/Add.cshtml");
        }
    }
}