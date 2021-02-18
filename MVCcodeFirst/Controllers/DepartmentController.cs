using MVCcodeFirst.Context;
using MVCcodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCcodeFirst.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentContext db = new DepartmentContext();
        // GET: Department
        public ActionResult Index()
        {
            return View(db.Departments.ToList());
        }

        // GET: Department/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Department/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department dept) {
            if (ModelState.IsValid) {
                db.Departments.Add(dept);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dept);
        }

        // GET: Department/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Department dept = db.Departments.Find(id);
            return View("Edit" , dept);
        }

        // POST: Department/Edit/5
        [HttpPost]
        public ActionResult Edit(Department dept)
        {
            db.Entry(dept).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Department dept = db.Departments.Find(id);
            return View("Delete" , dept);
        }

        [HttpPost]
        public ActionResult Delete(Department dept)
        {
            db.Departments.Remove(dept);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
