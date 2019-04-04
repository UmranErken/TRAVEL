using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.BOL.Entities
{
	[Table("Location")]
	public class Location
	{
		public int ID { get; set; }
		[StringLength(50), Column(TypeName = "varchar"), Display(Name = "Bölge Adı")]
		public string Name { get; set; }
		public ICollection<Tour> Tours { get; set; }
	}
}
