using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UlfNewIdentity.Controllers
{
    public class UserManagerController : Controller
    {
       
        // GET: UserManager
        public ActionResult Index()
        {

            return View();
        }

        // GET: UserManager/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserManager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserManager/Create
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

        // GET: UserManager/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserManager/Edit/5
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

        // GET: UserManager/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserManager/Delete/5
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
