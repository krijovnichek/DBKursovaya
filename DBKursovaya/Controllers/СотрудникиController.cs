using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DBKursovaya.Models;

namespace DBKursovaya.Controllers
{
    public class СотрудникиController : Controller
    {
        KursEntities1 db = new KursEntities1();
        // GET: Сотрудники
        public ActionResult Index()
        {
            return View(db.Сотрудники);
        }

        // GET: Сотрудники/Details/5
        public ActionResult Details(int id)
        {
            Сотрудники emp = db.Сотрудники.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // GET: Сотрудники/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Сотрудники/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "ID_сотрудника, Фамилия_сотрудника, Имя_сотрудника, Отчество_сотрудника, Дата_рождения, Отдел, Должность, Зарплата, Номер_телефона, e_mail")] Сотрудники emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Сотрудники.Add(emp);
                    db.SaveChanges();
                    
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(emp);
            }
        }

        // GET: Сотрудники/Edit/5
        public ActionResult Edit(int id)
        {
            Сотрудники emp = db.Сотрудники.Find(id);
            return View(emp);
        }

        // POST: Сотрудники/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID_сотрудника, Фамилия_сотрудника, Имя_сотрудника, Отчество_сотрудника, Дата_рождения, Отдел, Должность, Зарплата, Номер_телефона, e_mail")] Сотрудники emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                
            }
            catch
            {
                return View(emp);
            }
            return View(emp);
        }

        // GET: Сотрудники/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View();
        }

        // POST: Сотрудники/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Сотрудники emp = db.Сотрудники.Find(id);
                db.Сотрудники.Remove(emp);
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
