using BlokMath.Shapes;

namespace BlokMath.Solids
{
    public class Cube
    {
        public Cube(Square wall)
        {
            Wall = wall;
            d = a * (decimal)Math.Sqrt(3);
        }

        public Cube(decimal a) : this(new Square(a)) { }

        public Square Wall { get; set; }

        public decimal a { get => Wall.a; }
        public decimal d { get; private set; }
    }
}
