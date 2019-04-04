using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.BOL.Entities
{
	[Table("Payment")]
	public class Payment
	{
		public int ID{ get; set; }
		[Column(TypeName = "varchar"), StringLength(20)]
		public string Kind{ get; set; }
		
	}
}
