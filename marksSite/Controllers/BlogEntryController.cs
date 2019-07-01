using Microsoft.AspNetCore.Mvc;
using marksSite.Model;
using marksSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marksSite.Controllers
{
    public class BlogEntryController : Controller
    {
        IRepository<BlogEntry> entryRepo;

        public BlogEntryController(IRepository<BlogEntry> entryRepo)
        {
            this.entryRepo = entryRepo;
        }

        [HttpGet]
        public ViewResult Create(int id)
        {
            ViewBag.BlogId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(BlogEntry review)
        {
            entryRepo.Create(review);
            return RedirectToAction("../Blog/Details/" + review.BlogId);
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            ViewBag.ProductId = id;
            var model = entryRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(BlogEntry review)
        {
            entryRepo.Delete(review);
            return RedirectToAction("../Blog/Details/" + review.BlogId);
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = entryRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(BlogEntry review)
        {
            entryRepo.Edit(review);
            return RedirectToAction("../Blog/Details/" + review.BlogId);
        }
    }
}




