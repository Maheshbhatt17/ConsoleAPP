using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationmvc.Models;

namespace WebApplicationmvc.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        //[ActionName("hello")]
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Captain America!" };
            // return Content("Hii MVCC");
        //    ViewData["Movie"] = movie;
            return View(movie);
        }


        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        public ActionResult Index(int? pageIndex, string sort)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sort))
                sort = "HelloMVC";
            return Content(String.Format("pageIndex={0}& sort={1}",pageIndex,sort));
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByRelease(int year, int month)
        {
            return Content(year + "/" + month); 
        }
        [ActionName("hello")]
        public String Index()
        {
            return "The value is MVC";
        }
    }
}