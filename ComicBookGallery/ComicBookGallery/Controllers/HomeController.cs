using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Data;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ComicBook[] comicBooks = ComicBookRepository.GetAllComicBooks();
            return View(comicBooks);
        }

    }
}
