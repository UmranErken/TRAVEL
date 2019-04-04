using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Travel.BLL.Repositories;
using Travel.BOL.Entities;

namespace Travel.Controllers
{
	public class MemberController : Controller
	{
		Repository<Member> repoMember = new Repository<Member>();
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost, ValidateAntiForgeryToken]
		public ActionResult Login(string MailAddress, string Password)
		{
			if (!string.IsNullOrEmpty(MailAddress) && !string.IsNullOrEmpty(Password))
			{
				Member member = repoMember.GetBy(a => a.MailAddress == MailAddress && a.Password == Password);
				if (member != null)
				{
					FormsAuthentication.SetAuthCookie(MailAddress, true);
					Session["AdSoyad"] = member.Name + " " + member.SurName;
					return Redirect("/");
				}
				else
				{
					TempData["Hata"] = "Mail Adresi veya Şifre Hatalı";
					return RedirectToAction("Index");
				}
			}
			else TempData["Hata"] = "Mail Adresi veya Şifre boş geçilemez";
			return RedirectToAction("Index");
		}

		[HttpPost, ValidateAntiForgeryToken]
		public ActionResult SingUp(Member member)
		{
			member.LastDate = DateTime.Now;
			member.LastIP = Request.UserHostAddress;
			member.Role = "uye";

			//string deneme = FormsAuthentication.HashPasswordForStoringInConfigFile("deneme", "MD5");

			repoMember.Add(member);

			if (!string.IsNullOrEmpty(member.MailAddress) && !string.IsNullOrEmpty(member.Password))
			{
				if (member != null)
				{
					FormsAuthentication.SetAuthCookie(member.MailAddress, true);
					Session["AdSoyad"] = member.Name + " " + member.SurName;
					return Redirect("/");
				}
				else
				{
					TempData["Hata"] = "Mail Adresi veya Şifre Hatalı";
					return RedirectToAction("Index");
				}
			}
			else TempData["Hata"] = "Mail Adresi veya Şifre boş geçilemez";
			return RedirectToAction("Index");
		}


		public ActionResult Logout()
		{
			FormsAuthentication.SignOut();
			return Redirect("/");
		}
	}
}