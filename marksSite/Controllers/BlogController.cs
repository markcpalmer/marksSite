using Microsoft.AspNetCore.Mvc;
using marksSite.Model;
using marksSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marksSite.Controllers
{
    public class BlogController : Controller
    {
        IRepository<Blog> blogRepo;

        public BlogController(IRepository<Blog> blogRepo)
        {
            this.blogRepo = blogRepo;
        }

        public ViewResult Index()
        {
            var model = blogRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = blogRepo.GetById(id);
            return View(model);
        }
    }
}
