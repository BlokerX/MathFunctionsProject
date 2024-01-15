namespace BlokMath.Shapes
{
    public class Circle
    {
        public Circle(decimal r)
        {
            this.r = r;
        }

        public decimal r { get; private set; }

        public decimal Area() => r * OtherFunctions.PI * OtherFunctions.PI;

        public decimal Perimeter() => 2 * r * OtherFunctions.PI;
    }
}
