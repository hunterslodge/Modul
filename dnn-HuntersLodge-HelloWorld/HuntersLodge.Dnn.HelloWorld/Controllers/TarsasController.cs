﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dnn.HuntersLodge.HuntersLodge.Dnn.HelloWorld.Controllers
{
    public class TarsasController : Controller
    {
        // GET: Tarsas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tarsas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tarsas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tarsas/Create
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

        // GET: Tarsas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tarsas/Edit/5
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

        // GET: Tarsas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tarsas/Delete/5
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