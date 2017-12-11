using Data.Models;
using Domain;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cgaFinaldotNet.Controllers
{
    public class InsuranceCompanyController : Controller
    {
        InsuranceCompanyService ic = new InsuranceCompanyService();
        // GET: InsuranceCompany
        public ActionResult Index()
        {
            return View(ic.GetAll());
        }

        // GET: RendezVous/Details/5
        public ActionResult Details(int id)
        {
            return View(ic.GetById(id));
        }

        // GET: InsuranceCompany/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InsuranceCompany/Create
        [HttpPost]
        public ActionResult Create(insurancecompany i)
        {
            try
            {
                // TODO: Add insert logic here
                ic.Add(i);
                ic.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: InsuranceCompany/Edit/5
        public ActionResult Edit(int id)
        {
            insurancecompany i = ic.GetById(id);

            return View(i);
        }

        // POST: InsuranceCompany/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, insurancecompany insurancecompany)
        {
            insurancecompany i = ic.GetById(id);
            i.Address = insurancecompany.Address;
            i.CompName = insurancecompany.CompName;
            i.Fax = insurancecompany.Fax;

            ic.Update(i);
            ic.Commit();
            return RedirectToAction("Index");
        }

        // GET: insurancecompany/Delete/5
        public ActionResult Delete(int id)
        {
            insurancecompany i = ic.GetById(id);
            return View(i);
        }

        // POST: insurancecompany/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, insurancecompany insurancecompany)
        {
            insurancecompany i1 = new insurancecompany();
            i1 = ic.GetById(id);
            ic.Delete(i1);
            ic.Commit();
            return RedirectToAction("Index");
        }
    }
}
