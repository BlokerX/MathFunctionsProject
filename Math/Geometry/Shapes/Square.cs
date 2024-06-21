using BlokMath.Functions;

namespace BlokMath.Geometry.Shapes
{
    public class Square : Rectangle
    {
        public Square(decimal a) : base(a, a) { }

        public new decimal a
        {
            get => base.a;
            protected set => base.a = b = value;
        }

        public new void Set_a(decimal a)
        {
            this.a = a;
        }
        
        public void Set_d(decimal d)
        {
            this.a = d/OtherFunctions.SquareRoot(2);
        }
        
        public void Set_Circumference(decimal circumference)
        {
            this.a = circumference/4;
        }
        
        public void Set_Area(decimal area)
        {
            this.a = OtherFunctions.SquareRoot(area);
        }
    }
}
