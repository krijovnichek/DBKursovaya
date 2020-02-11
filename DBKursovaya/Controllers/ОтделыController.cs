using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DBKursovaya.Models;

namespace DBKursovaya.Controllers
{
    public class ОтделыController : Controller
    {
        KursEntities1 db = new KursEntities1();
        public ActionResult Index()
        {
            return View(db.Отделы);
        }

        // GET: Отделы/Details/5
        public ActionResult Details(string name)
        {
            Отделы otd = db.Отделы.Find(name);
            if (otd == null)
            {
                return HttpNotFound();
            }
            return View(otd);
        }

        // GET: Отделы/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Отделы/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Название_подразделения, Наличие_какой-нибудь_фигни, Какая-нибудь еще штука, ID_руководителя")] Отделы otd)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Отделы.Add(otd);
                    db.SaveChanges();

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            return View(otd);
        }

        // GET: Отделы/Edit/5
        public ActionResult Edit(string name)
        {
            Отделы otd = db.Отделы.Find(name);
            return View(otd);
        }

        // POST: Отделы/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Название_подразделения, Наличие_какой-нибудь_фигни, Какая-нибудь еще штука, ID_руководителя")] Отделы otd)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(otd).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
            return View(otd);
        }

        // GET: Отделы/Delete/5
        public ActionResult Delete(string name)
        {
            if (name == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View();
        }

        // POST: Отделы/Delete/5
        [HttpPost]
        public ActionResult Delete(string name, FormCollection collection)
        {
            try
            {
                Отделы otd = db.Отделы.Find(name);
                db.Отделы.Remove(otd);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
