using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR.Models
{
    public class Grids
    {
        public Grids(string c1, string c2)
        {
            Column1 = c1;
            Column2 = c2;

        }
        public string Column1 { get; set; }
        public string Column2 { get; set; }


    }
}
