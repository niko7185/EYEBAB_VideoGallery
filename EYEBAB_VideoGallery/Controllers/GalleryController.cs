using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Localization;
using Services;

namespace EYEBAB_VideoGallery.Controllers
{

    public class GalleryController : Controller
    {

        public IActionResult Index()
        {

            ViewData["Title"] = "Video Gallery";

            var requestCulture = HttpContext.Features.Get<IRequestCultureFeature>();
            GalleryService service = new GalleryService();

            ViewBag.Culture = requestCulture;

            //Replace with a service connected to the database
            ViewBag.Categories = null;//service.GetCategories();

            return View();
        }

    }
}
