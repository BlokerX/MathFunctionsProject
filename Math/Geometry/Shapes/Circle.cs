using BlokMath.Functions;

namespace BlokMath.Geometry.Shapes
{
    public class Circle
    {
        public Circle(decimal r)
        {
            this.r = r;
        }

        public decimal r { get; private set; }

        public decimal Area => r * r * OtherFunctions.PI;

        public decimal Circumference => 2 * r * OtherFunctions.PI;
    }
}
