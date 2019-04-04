using Travel.BOL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.BLL.Repositories;
using Travel.ViewModel;
using System.Data.Entity;

namespace Travel.Controllers
{
    public class TourController : Controller
	{
		Repository<Tour> repoTour = new Repository<Tour>();
		Repository<Picture> repoPicture = new Repository<Picture>();
		

        // GET: Tour
        public ActionResult Index()
        {
			ViewBag.TourPicture = repoPicture.GetAll().FirstOrDefault(f => f.PIndex == 1);
			return View(repoTour.GetAll().ToList());
        }
        public ActionResult Detail(int ID)
        {
            return View(repoTour.GetAll().FirstOrDefault(f=>f.ID==ID));
        }

	

	}
}