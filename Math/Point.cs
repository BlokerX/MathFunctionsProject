using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokMath
{
    public class Point
    {
        public Point(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }

        public decimal x { get; set; }
        public decimal y { get; set; }
    }
}
