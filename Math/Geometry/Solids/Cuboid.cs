using BlokMath.Geometry.Shapes;

namespace BlokMath.Geometry.Solids
{
    public class Cuboid
    {
        protected Cuboid() { }
        public Cuboid(decimal a, decimal b, decimal h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }

        //todo repair this
        //public Cuboid(Rectangle wallFrontBack, Rectangle wallLeftRight, Rectangle wallTopBottom)
        //{
        //    a = wallFrontBack.a;
        //    b = wallLeftRight.a;
        //    h = wallFrontBack.b;
        //}

        //todo repair this
        public Rectangle GetWallFrontBack() => new Rectangle(a, h);
        public Rectangle GetWallLeftRight() => new Rectangle(b, h);
        public Rectangle GetWallTopBottom() => new Rectangle(a, b);


        private decimal _a;
        public decimal a
        {
            get => _a;
            set
            {
                _a = value;
            }
        }

        private decimal _b;
        public decimal b
        {
            get => _b;
            set
            {
                _b = value;
            }
        }

        private decimal _h;
        public decimal h
        {
            get => _h;
            set
            {
                _h = value;
            }
        }

        public decimal d => (decimal)Math.Sqrt(double.Parse((a * a + b * b + h * h).ToString()));

        public decimal LateralSurfaceArea => (a * h * 2) + (b * h * 2);
        public decimal BaseArea => a * b;
        public decimal TotalSurfaceArea => LateralSurfaceArea + (BaseArea * 2);
        public decimal Volume => a * b * h;
    }
}
