using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    public class DishesController : Controller
    {
        // GET: DishesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DishesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DishesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DishesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DishesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DishesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DishesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DishesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
