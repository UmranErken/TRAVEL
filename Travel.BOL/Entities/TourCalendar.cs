using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.BOL.Entities
{
	[Table("TourCalendar")]
	public class TourCalendar
	{
		[Key, Column(Order = 0)]
		public int TourID { get; set; }

		[Key, Column(Order = 1)]
		public int CalendarID { get; set; }
		public virtual Tour Tour { get; set; }
		public virtual Calendar Calendar { get; set; }
	}
}
