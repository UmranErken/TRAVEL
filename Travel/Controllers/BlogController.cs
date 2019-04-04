using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.BLL.Repositories;
using Travel.BOL.Entities;

namespace Travel.Controllers
{
    public class BlogController : Controller
	{
		Repository<Picture> repoPicture = new Repository<Picture>();
		// GET: Blog
		public ActionResult Index()
        {
			ViewBag.BlogPicture = repoPicture.GetAll().FirstOrDefault(f => f.PIndex == 3);
			return View();
        }
    }
}