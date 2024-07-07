using BlokMath.Functions;
using BlokMath.Geometry.Shapes;

namespace BlokMath.Geometry.Solids
{
    public class Cube : Cuboid
    { //todo repair this
        public Cube(Square face) : base()
        {
            a = face.a;
        }

        public Cube(decimal a) : this(new Square(a)) { }

        public Square Face() => new Square(a);

        private decimal _a;
        public new decimal a
        {
            get => this._a;
            set
            {
                base.a = value;
                base.b = value;
                base.h = value;
                this._a = value;
            }
        }
        public new decimal MainDiagonal => a * OtherFunctions.SquareRoot(3);
        public new decimal LateralSurfaceArea => 4 * a * a;
        public new decimal BaseArea => 4 * a * a;
        public new decimal TotalSurfaceArea => 6 * a * a;
        public new decimal Volume => a * a * a;

        public void Set_a(decimal a)
        {
            this.a = a;
        }

        public void Set_MainDiagonal(decimal mainDiagonal)
        {
            this.a = mainDiagonal / OtherFunctions.SquareRoot(3);
        }

        public void Set_LateralSurfaceArea(decimal lateralSurfaceArea)
        {
            this.a = OtherFunctions.SquareRoot(lateralSurfaceArea / 4);
        }

        public void Set_TotalSurfaceArea(decimal totalSurfaceArea)
        {
            this.a = OtherFunctions.SquareRoot(totalSurfaceArea / 6);
        }

        public void Set_Volume(decimal volume)
        {
            this.a = OtherFunctions.CubeRoot(volume);
        }

        public void Set_DiagonalOfFaceOfCube(decimal diagonalOfFaceOfCube)
        {
            this.a = diagonalOfFaceOfCube / OtherFunctions.SquareRoot(2);
        }

        public void Set_SurfaceAreaOfFace(decimal surfaceAreaOfFace)
        {
            this.a = OtherFunctions.SquareRoot(surfaceAreaOfFace);
        }

    }
}
