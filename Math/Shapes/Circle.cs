using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokMath.Shapes
{
    public class Circle
    {
        public Circle(decimal r)
        {
            this.r = r;
        }

        public decimal r { get; private set; }
    }
}
