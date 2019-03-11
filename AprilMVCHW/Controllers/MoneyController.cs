using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AprilMVCHW.Models;
using AprilMVCHW.Models.ViewModels;

namespace AprilMVCHW.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MoneyTemplate()
        {
            var passDataViewModel = new PassDataViewModel { Passdatalist = new DataList()};
            var a = passDataViewModel.Passdatalist.list;
            return View(a);
        }

        // GET: Money/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Money/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Money/Create
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

        // GET: Money/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Money/Edit/5
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

        // GET: Money/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Money/Delete/5
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
