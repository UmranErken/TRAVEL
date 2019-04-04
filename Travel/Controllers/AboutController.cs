using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.BLL.Repositories;
using Travel.BOL.Entities;

namespace Travel.Controllers
{
    public class AboutController : Controller
    {
		Repository<Picture> repoPicture = new Repository<Picture>();
		// GET: About
		public ActionResult Index()
        {
			ViewBag.AboutPicture = repoPicture.GetAll().FirstOrDefault(f => f.PIndex == 4);
			return View();
        }
    }
}