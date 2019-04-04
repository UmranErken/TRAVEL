using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.BOL.Entities
{
    [Table("Picture")]
    public class Picture
    {
        public int ID { get; set; }
        [StringLength(30), Column(TypeName = "varchar"), Display(Name = "Resim Yolu")]
        public string Name { get; set; }
        [StringLength(30), Column(TypeName = "varchar"), Display(Name = "Resim Yolu")]
        public string Path { get; set; }
        [Display(Name ="Görüntülenme Sırası")]
        public int PIndex { get; set; }
    }
}
