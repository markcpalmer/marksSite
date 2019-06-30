using Microsoft.AspNetCore.Mvc;
using marksSite.Model;
using marksSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marksSite.Controllers
{
    public class ProductController : Controller
    {
        IRepository<Product> productRepo;

        public ProductController(IRepository<Product> productRepo)
        {
            this.productRepo = productRepo;
        }

        public ViewResult Index()
        {
            var model = productRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = productRepo.GetById(id);
            return View(model);
        }
    }
}
