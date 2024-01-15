using BlokMath.Shapes;

namespace BlokMath.Solids
{
    public class Cube : Cuboid
    {
        public Cube(Square wall) : base(wall.a, wall.a, wall.a)
        {
            Wall = wall;
        }

        public Cube(decimal a) : this(new Square(a)) { }

        private Square _wall;
        public Square Wall
        {
            get => Wall;
            set
            {
                WallFrontBack = WallLeftRight = WallTopBottom = _wall = value;
            }
        }

        public new decimal a
        {
            get => Wall.a;
            //set
            //{
            //
            //}
        }
        public new decimal d => a * (decimal)Math.Sqrt(3);
        public new decimal LateralSurfaceArea => 4 * Wall.Area;
        public new decimal TotalSurfaceArea => 6 * Wall.Area;
        public new decimal Volume => a * a * a;
    }
}
