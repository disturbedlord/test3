using MVCcodeFirst.Context;
using MVCcodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCcodeFirst.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext db = new EmployeeContext();
        //DepartmentContext db1 = new DepartmentContext();
        // GET: Employee
        [HttpGet]
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        [HttpGet]
        // GET: Employee/Create
        public ActionResult Create()
        {
            List<int> l = new List<int>();
            l.Add(1);
            //l.Add("two");
            //l.Add("three");
            ViewBag.data = l;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp) {
            if (ModelState.IsValid) {
                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        // GET: Employee/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Employee/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Employee/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Employee/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
