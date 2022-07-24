using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;
using System.Linq;

namespace MovieApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieContext context;
        public MovieController(MovieContext context)
        {
            this.context = context;
        }
        
        // GET: MovieController
        public ActionResult Index()
        {
            var movies = context.Movies.ToList();
            return View(movies);
        }

        //// GET: MovieController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: MovieController/Create
        public IActionResult CreateMovieForm( )
        {
            Movie movie = new Movie();
            
            return View();
        }

        [HttpPost]
        public IActionResult CreateMovie( Movie movie)
        {
            if (ModelState.IsValid)
            {
                context.Movies.Add(movie);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
           
            return View("Create MovieForm", movie);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Movie movie = context.Movies.Find(Id);

            return View("Edit",movie);

        }
        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            context.Movies.Update(movie);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Delete(int Id)
        {
            Movie movie = context.Movies.Find(Id);
            context.Movies.Remove(movie);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }

        
       
    }






        //// POST: MovieController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create (IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: MovieController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: MovieController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: MovieController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: MovieController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
//    }
//}
