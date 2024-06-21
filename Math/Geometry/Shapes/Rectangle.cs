namespace BlokMath.Geometry.Shapes
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

        public void Set_a(decimal a)
        {
            this.a = a;
        }

        public void Set_b(decimal b)
        {
            this.b = b;
        }

        public decimal d => (decimal)Math.Sqrt(double.Parse((a * a + b * b).ToString()));

        public decimal Area => a * b;

        public decimal Circumference => (a + b) * 2;
    }
}
