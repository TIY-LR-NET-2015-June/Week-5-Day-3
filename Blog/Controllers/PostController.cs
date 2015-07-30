using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        Posts posts = new Posts();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int ID)
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult Details(int ID)
        {
            return View();
        }

        public ActionResult Delete(int ID)
        {
            return View();
        }
    }
}