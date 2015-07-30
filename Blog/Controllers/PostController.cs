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
            return View(posts.PostDB.ToList().OrderBy(p => p.PublishedOn));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Post post)
        {
            posts.PostDB.Add(post);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            return View(posts.PostDB.Find(ID));
        }
        [HttpPost]
        public ActionResult Edit(Post post)
        {
            posts.PostDB.Remove(posts.PostDB.Find(post.ID));
            posts.PostDB.Add(post);
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            return View(posts.PostDB.ToList());
        }

        public ActionResult Details(int ID)
        {
            return View(posts.PostDB.Find(ID));
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            return View(posts.PostDB.Find(ID));
        }
        [HttpPost]
        public ActionResult Delete(Post post)
        {
            posts.PostDB.Remove(post);
            return RedirectToAction("List");
        }
    }
}