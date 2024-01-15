namespace BlokMath.Shapes
{
    public class Rectangle
    {
        public decimal a { get; protected set; }
        public decimal b { get; protected set; }

        public Rectangle(decimal a, decimal b)
        {
            this.a = a;
            this.b = b;
        }

        public decimal d => (decimal)Math.Sqrt(double.Parse((a * a * 2).ToString()));

        public decimal Area => a * b;

        public decimal Perimeter => (a + b) * 2;
    }
}
