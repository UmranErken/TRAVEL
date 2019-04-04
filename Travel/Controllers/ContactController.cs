using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Travel.BLL.Repositories;
using Travel.BOL.Entities;
using Travel.DAL.Context;

namespace Travel.Controllers
{
	public class ContactController : Controller
	{
		Context db = new Context();
		Repository<Contact> repoContact = new Repository<Contact>();
		// GET: Contact
		public ActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Index(Contact modelim, HttpPostedFileBase Dosya)
		{
			modelim.KayitTarih = DateTime.Now;
			repoContact.Add(modelim);
			MailGonder(modelim);
			return View();
		}
		void MailGonder(Contact Model)
		{
			try
			{
				StringBuilder sb = new StringBuilder();
				MailMessage mail = new MailMessage();
				mail.From = new MailAddress("umran.cakal1@gmail.com");
				mail.To.Add(new MailAddress(Model.Mail));
				mail.Subject = Model.Subject;
				sb.Append("Aşağıdaki bilgileri bulunan bir ziyaretçiden mesaj aldınız. <br/> ");
				sb.Append("Adı:" + Model.FirstName + "<br/>");
				sb.Append("Soyadı:" + Model.LastName + "<br/>");
				sb.Append("Mesajı:" + Model.Message + "<br/>");
				mail.Body = sb.ToString();
				mail.IsBodyHtml = true;
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential("umran.cakal1@gmail.com", "Hacker22.");
				smtpClient.Send(mail);


			}
			catch (Exception ex)
			{

			}
		}

	}
}