using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JsonPlaceHolder.Web.Controllers
{
    public class PhotosController : Controller
    {
        // GET: Photos
        public ActionResult LargePhotos()
        {
            return View();
        }
        // GET: Photos
        public ActionResult SmallPhotos() 
        {
            return View();
        }
    }
}