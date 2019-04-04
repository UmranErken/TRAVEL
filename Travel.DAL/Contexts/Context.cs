using Travel.BOL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.DAL.Context
{
	public class Context : DbContext
	{
		public Context() : base("CS1")
		{ }
		public DbSet<Admin> Admin { get; set; }
		public DbSet<Category> Category { get; set; }
		public DbSet<Tour> Tour { get; set; }
		public DbSet<Reservation> Reservation { get; set; }
		public DbSet<Member> Member { get; set; }
		public DbSet<Payment> Payment { get; set; }
		public DbSet<Slider> Slider { get; set; } 
		public DbSet<Hotel> Hotel { get; set; }
		public DbSet<Location> Location { get; set; }
		public DbSet<Picture> Picture { get; set; }
		public DbSet<Contact> Contact { get; set; }
		public DbSet<Calendar>Calendar { get; set; }
		
		
	}
}
