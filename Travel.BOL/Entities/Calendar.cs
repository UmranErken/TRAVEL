using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.BOL.Entities
{
	[Table("CalendarT")]
	public class Calendar
	{
		public int ID { get; set; }
		[DataType(DataType.DateTime), Display(Name = "Gidiş Tarihi")]
		public DateTime FDate { get; set; }
		[DataType(DataType.DateTime), Display(Name = "Dönüş Tarihi")]
		public DateTime SDate { get; set; }
		public ICollection<TourCalendar> TourCalendar { get; set; }
	}
}
