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

        public decimal d => r * 2;

        public decimal Area => r * r * OtherFunctions.PI;

        public decimal Circumference => 2 * r * OtherFunctions.PI;

        public void Set_r(decimal r)
        {
            this.r = r;
        }

        public void Set_d(decimal d)
        {
            this.r = d / 2;
        }

        public void Set_Circumference(decimal circumference)
        {
            this.r = circumference / (2 * OtherFunctions.PI);
        }

        public void Set_Area(decimal area)
        {
            this.r = OtherFunctions.SquareRoot(area / OtherFunctions.PI);
        }
    }
}
