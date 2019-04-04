using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.BOL.Entities
{
	[Table("Slider")]
	public class Slider
	{
		public int ID { get; set; }

		[StringLength(150), Column(TypeName = "varchar"), Display(Name = "Slayt Resmi")]
		public string Picture { get; set; }
		[StringLength(100), Column(TypeName = "varchar"), Display(Name = "Üst")]
        public string SubTitle { get; set; }
        [StringLength(150), Column(TypeName = "varchar"), Display(Name = " Başlık")]
        public string Title { get; set; }
        [Display(Name ="Görüntülenme Sırası")]
        public int pIndex { get; set; }



    }
}

