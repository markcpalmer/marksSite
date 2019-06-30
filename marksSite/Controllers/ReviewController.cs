using Microsoft.AspNetCore.Mvc;
using marksSite.Model;
using marksSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marksSite.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;

        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        [HttpGet]
        public ViewResult Create(int id)
        {
            ViewBag.ProductId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {
            reviewRepo.Create(review);
            return RedirectToAction("../Product/Details/" + review.ProductId);
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            ViewBag.ProductId = id;
            var model = reviewRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Review review)
        {
            reviewRepo.Delete(review);
            return RedirectToAction("../Product/Details/" + review.ProductId);
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = reviewRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Review review)
        {
            reviewRepo.Edit(review);
            return RedirectToAction("../Product/Details/" + review.ProductId);
        }
    }
}




