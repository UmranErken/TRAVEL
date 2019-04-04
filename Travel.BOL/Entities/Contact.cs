using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.BOL.Entities
{
    [Table("Contact")]
   public class Contact
    {
        public int ID { get; set; }
        [StringLength(30), Column(TypeName = "varchar"), Display(Name = "Name"),Required(ErrorMessage ="Please enter your name!")]
        public string FirstName { get; set; }
        [StringLength(30), Column(TypeName = "varchar"), Display(Name = "Surname"), Required(ErrorMessage = "Please enter your surname!")]
        public string LastName { get; set; }
        [StringLength(30), Column(TypeName = "varchar"), Display(Name = "EMail")]
        public string Mail { get; set; }
        [StringLength(30), Column(TypeName = "varchar"), Display(Name = "Subject")]
        public string Subject { get; set; }
        [StringLength(500), Column(TypeName = "varchar"), Display(Name = "Message :")]
        public string Message { get; set; }
        public DateTime KayitTarih { get; set; }
        

    }
}
