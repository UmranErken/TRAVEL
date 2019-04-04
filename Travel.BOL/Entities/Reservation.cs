using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.BOL.Entities
{

	[Table("Reservation")]
	public class Reservation
	{
		public int ID { get; set; }

		[Column(TypeName = "varchar"), StringLength(50)]
		public string Name { get; set; }
		public int MemberID { get; set; }
		public Member Member { get; set; }
	}
}
