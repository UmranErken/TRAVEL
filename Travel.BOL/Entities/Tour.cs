using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Travel.BOL.Entities
{
	[Table("Tour")]
	public class Tour
	{

		public int ID { get; set; }

		[Column(TypeName = "varchar"), StringLength(50)]
		public string Picture { get; set; }
		[Column(TypeName = "varchar"), StringLength(50)]
		public string Name { get; set; }
		[Display(Name = "Tur Fiyatı")]
		public int Price { get; set; }
		[Column(TypeName = "varchar"), StringLength(10)]
		public string Day { get; set; }
		[Column(TypeName = "varchar"), StringLength(50)]
		public string Title { get; set; }
		[Display(Name = "Beğeni Sayısı")]
		public int Like { get; set; }

		[Column(TypeName = "text")]
		public string explanation { get; set; }
		[Display(Name = "Maksimum kişi sayısı")]
		public int MaxPerson { get; set; }
		[Display(Name = "Görüntülenme Sırası")]
		public int PIndex { get; set; }
		public int CategoryID { get; set; }
		public Category Category { get; set; }
		public Location Location { get; set; }
		public ICollection<TourCalendar>TourCalendar{ get; set; }
	}
}