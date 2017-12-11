using Domain;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cgaFinaldotNet.Controllers
{
    public class RendezVousController : Controller
    {
        RendezVousService rc = new RendezVousService();
        // GET: RendezVous
        public ActionResult Index()
        {
            return View(rc.GetAll());
        }

        // GET: RendezVous/Details/5
        public ActionResult Details(int id)
        {
            return View(rc.GetById(id));
        }

        // GET: RendezVous/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RendezVous/Create
        [HttpPost]
        public ActionResult Create(rendez_vous r)
        {
            try
            {
                // TODO: Add insert logic here
                rc.Add(r);
                rc.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RendezVous/Edit/5
        public ActionResult Edit(int id)
        {
            rendez_vous r = rc.GetById(id);

            return View(r);
        }

        // POST: RendezVous/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, rendez_vous rendezVous)
        {
            rendez_vous r = rc.GetById(id);
            r.DateRendezVous = rendezVous.DateRendezVous;
            r.Description = rendezVous.Description;
            r.NomAssurance = rendezVous.NomAssurance;

            rc.Update(r);
            rc.Commit();
            return RedirectToAction("Index");
        }

        // GET: RendezVous/Delete/5
        public ActionResult Delete(int id)
        {
            rendez_vous r = rc.GetById(id);
            return View(r);
        }

        // POST: RendezVous/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, rendez_vous rendezVous)
        {
            rendez_vous r1 = new rendez_vous();
            r1 = rc.GetById(id);
            rc.Delete(r1);
            rc.Commit();
            return RedirectToAction("Index");
        }
    }
}
