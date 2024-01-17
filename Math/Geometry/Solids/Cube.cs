using BlokMath.Geometry.Shapes;

namespace BlokMath.Geometry.Solids
{
    public class Cube : Cuboid
    { //todo repair this
        public Cube(Square wall) : base()
        {
            a = wall.a;
        }

        public Cube(decimal a) : this(new Square(a)) { }

        public Square Wall() => new Square(a);

        private decimal _a;
        public new decimal a
        {
            get => this.a;
            set
            {
                base.a = value;
                base.b = value;
                base.h = value;
                this._a = value;
            }
        }
        public new decimal d => a * (decimal)Math.Sqrt(3);
        public new decimal LateralSurfaceArea => 4 * a * a;
        public new decimal BaseArea => 4 * a * a;
        public new decimal TotalSurfaceArea => 6 * a * a;
        public new decimal Volume => a * a * a;
    }
}
