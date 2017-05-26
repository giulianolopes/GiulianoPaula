using Giuliano.Paula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Giuliano.Paula.Controllers
{
    public class CategoriesController : Controller
    {
        private static IList<Category> categories = new List<Category>()
        {
            new Category() {CategoryId = 1, Name = "Cachorro" },
             new Category() {CategoryId = 2, Name = "Cavalo" },
              new Category() {CategoryId = 3, Name = "Camelo" },
               new Category() {CategoryId = 4, Name = "Coelho" },
                new Category() {CategoryId = 3, Name = "Canguru" },
        };
        // GET: Categories
        public ActionResult Index()
        {
            return View(categories.OrderBy(c =>c.Name));
        }
       
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            categories.Add(category);
            category.CategoryId = categories.Select(m => m.CategoryId).Max() + 1;
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(categories.Where(
            m => m.CategoryId == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            categories.Remove(categories.Where( c => c.CategoryId == category.CategoryId).First());
            categories.Add(category);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            return View(categories.Where(
            m => m.CategoryId == id).First());
        }

        public ActionResult Delete(long id)
        {
            return View(categories.Where(
            m => m.CategoryId == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Category category)
        {
            categories.Remove(categories.Where(
            c => c.CategoryId == category.CategoryId).First());
            return RedirectToAction("Index");
        }
    }
}