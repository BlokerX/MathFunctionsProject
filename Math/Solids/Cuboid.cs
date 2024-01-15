using BlokMath.Shapes;

namespace BlokMath.Solids
{
    public class Cuboid
    {
        public Cuboid(decimal a, decimal b, decimal h)
        {
            //this.a = a;
            //this.b = b;
            //this.h = h;

            WallFrontBack = new Rectangle(a, h);
            WallLeftRight = new Rectangle(b, h);
            WallTopBottom = new Rectangle(a, b);
        }

        public Cuboid(Rectangle wallFrontBack, Rectangle wallLeftRight, Rectangle wallTopBottom)
        {
            //this.a = wallFrontBack.a;
            //this.b = wallLeftRight.a;
            //this.h = wallFrontBack.b;

            this.WallFrontBack = wallFrontBack;
            this.WallLeftRight = wallLeftRight;
            this.WallTopBottom = wallTopBottom;
        }

        public Rectangle WallFrontBack { get; protected set; }
        public Rectangle WallLeftRight { get; protected set; }
        public Rectangle WallTopBottom { get; protected set; }

        public decimal a
        {
            get => WallTopBottom.a;
            //set
            //{
            //    WallTopBottom.a = WallFrontBack.a = value;
            //}
        }

        public decimal b
        {
            get => WallTopBottom.b;
            //set
            //{
            //    WallTopBottom.b = WallLeftRight.a = value;
            //}
        }

        public decimal h
        {
            get => WallFrontBack.b;
            //set
            //{
            //    WallFrontBack.b = WallLeftRight.b = value;
            //}
        }

        public decimal d => (decimal)Math.Sqrt(double.Parse(((a * a) + (b * b) + (h * h)).ToString()));

        public decimal LateralSurfaceArea => (WallFrontBack.Area * 2) + (WallLeftRight.Area * 2);
        public decimal TotalSurfaceArea => LateralSurfaceArea + (WallTopBottom.Area * 2);
        public decimal Volume => a * b * h;
    }
}
