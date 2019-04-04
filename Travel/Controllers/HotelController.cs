using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.BLL.Repositories;
using Travel.BOL.Entities;

namespace Travel.Controllers
{
    public class HotelController : Controller
    {
		Repository<Hotel> repoHotel = new Repository<Hotel>();
		Repository<Picture> repoPicture = new Repository<Picture>();
		// GET: Hotel
		public ActionResult Index()
        {
			ViewBag.HotelPicture = repoPicture.GetAll().FirstOrDefault(f => f.PIndex == 2);
			return View(repoHotel.GetAll().ToList());
		}
		public ActionResult Detail(int ID)
		{
			return View(repoHotel.GetAll().FirstOrDefault(f => f.ID == ID));
		}
	}
}