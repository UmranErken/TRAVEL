using Travel.BOL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel.ViewModel
{
    public class IndexVM
    {
        public ICollection<Slider> Sliders { get; set; }
        public ICollection<Tour> Tours { get; set; }
       
        //public ICollection<Tour> PopularTours { get; set; }
	
	}
}