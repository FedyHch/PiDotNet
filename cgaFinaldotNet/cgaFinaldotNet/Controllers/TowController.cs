using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cgaFinaldotNet.Controllers
{
    public class TowController : Controller
    {
        TowService ts = new TowService();
        // GET: Tow
        public ActionResult Index()
        {
            IEnumerable<tow> liste = ts.afficher();
            return View(liste);
        }

        // GET: Tow/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tow/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tow/Create
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

        // GET: Tow/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tow/Edit/5
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

        // GET: Tow/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tow/Delete/5
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
