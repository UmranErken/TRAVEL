using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.BOL.Entities
{
	[Table("Hotel")]
	public class Hotel
	{
		public int ID { get; set; }

		[Column(TypeName = "varchar"), StringLength(50)]
		public string Picture { get; set; }
		[Column(TypeName = "varchar"), StringLength(50)]
		public string Name { get; set; }
		[Display(Name = "Otel Fiyatı")]
		public int Price { get; set; }
		[Column(TypeName = "varchar"), StringLength(50)]
		public string Title { get; set; }
		[Display(Name = "Beğeni Sayısı")]
		public int Like { get; set; }
		[Display(Name = "Görüntülenme Sırası")]
		public int PIndex { get; set; }
		[Column(TypeName = "varchar"), StringLength(100)]
		public string Description { get; set; }
		[Column(TypeName = "text")]
		public string HotelFeatures { get; set; }

		public int CategoryID { get; set; }
		public Category Category { get; set; }
	}
}
