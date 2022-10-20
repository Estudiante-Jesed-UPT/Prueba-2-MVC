using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prueba_2_MVC.Models;

namespace Prueba_2_MVC.Controllers
{
    public class PerrosController : Controller
    {
        // GET: Perros
        public ActionResult Index()
        {
            return View();
        }

        // GET: Perros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Perros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Perros/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Perros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Perros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Perros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Perros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
