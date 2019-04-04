using Travel.BOL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Travel.BLL.Repositories;
using Travel.ViewModel;
using System.Data.Entity;
using Travel.DAL.Context;

namespace Travel.Controllers
{
    public class HomeController : Controller
    {
        Repository<Admin> repoAdmin = new Repository<Admin>();
        Repository<Slider> repoSlider= new Repository<Slider>();
        Repository<Category> repoCategory= new Repository<Category>();
        Repository<Picture> repoPicture= new Repository<Picture>();

		Context db = new Context();
        // GET: Home
        public ActionResult Index()
        {

			IndexVM IndexVM = new IndexVM
			{
				Sliders = repoSlider.GetAll().OrderBy(o => o.pIndex).ToList(),
			
            };
			ViewBag.Location = new SelectList(db.Location.ToList(),"ID", "Name");
	
			return View(IndexVM);
        }
        public ActionResult Login(string ReturnUrl)
        {
            if (User.Identity.IsAuthenticated) FormsAuthentication.SignOut();
            ViewBag.rtn = ReturnUrl;
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Login(string kullaniciAdi, string pass, string rURL)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(pass))
            {
                Admin admin = repoAdmin.GetBy(a => a.UserName == kullaniciAdi && a.Password == pass);
                if (admin != null)
                {
                    FormsAuthentication.SetAuthCookie(kullaniciAdi, true);
                    Session["AdSoyad"] = admin.NameSurname;
                    if (!string.IsNullOrEmpty(rURL)) return Redirect(rURL);
                    else return Redirect("/admin");
                }
                else
                {
                    ViewBag.Hata = "Kullanıcı Adı veya Şifre Hatalı";
                }
            }
            else ViewBag.Hata = "Kullanıcı Adı ve Şifre Gerekli";
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
		public ActionResult Header()
		{
			return PartialView(repoCategory.GetAll().Include(i => i.Children));
		}
		




	}
}