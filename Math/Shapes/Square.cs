namespace BlokMath.Shapes
{
    public class Square
    {
        public Square(decimal a)
        {
            this.a = a;

            this.d = (decimal)Math.Sqrt(double.Parse((a * a * 2).ToString()));
        }

        //public Square(decimal d)
        //{
        //    this.d = d;
        //}

        public decimal a { get; protected set; }

        public decimal d { get; private set; }

        public decimal Area() => a * a;

        public decimal Perimeter() => a * 4;
    }
}
