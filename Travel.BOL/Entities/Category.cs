using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.BOL.Entities
{

	[Table("Category")]
	public class Category
	{
		public int ID { get; set; }

		[StringLength(30), Column(TypeName = "varchar"), Display(Name = "Kategori Adı")]
		public string Name { get; set; }

		[Display(Name = "Görüntülenme Sırası")]
		public int PIndex { get; set; }
        [StringLength(30), Column(TypeName = "varchar")]
        public string Link { get; set; }


        public int? ParentID { get; set; }

		[ForeignKey("ParentID")]
		public Category Parent { get; set; }

		public ICollection<Category> Children { get; set; }
		public ICollection<Tour> Tours { get; set; }
	}
}
