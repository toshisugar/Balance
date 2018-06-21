using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Balance.Models
{
    public class HomeInputViewModel
    {
        public string Name { get; set; }
    }

    public class HomeBmiViewModel
    {
        public double Weight { get; set; }
        public double Height { get; set; }
    }
}