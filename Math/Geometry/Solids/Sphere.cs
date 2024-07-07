using BlokMath.Functions;
using BlokMath.Geometry.Shapes;

namespace BlokMath.Geometry.Solids
{
    public class Sphere
    { //todo repair this
        public Sphere(Circle circleCrossSection)
        {
            CircleCrossSection = circleCrossSection;
        }

        public Sphere(decimal r) : this(new Circle(r)) { }

        public Circle CircleCrossSection { get; private set; }
        public decimal r { get => CircleCrossSection.r; }

        public decimal SurfaceArea => 4 * OtherFunctions.PI * r * r;
        public decimal Volume => r * r * r * (4 / 3) * OtherFunctions.PI;

        public void Set_r(decimal r)
        {
            CircleCrossSection?.Set_r(r);
        }

        public void Set_d(decimal d)
        {
            CircleCrossSection?.Set_d(d);
        }

        public void Set_CircleCrossSectionCircumference(decimal circumference)
        {
            CircleCrossSection?.Set_Circumference(circumference);
        }

        public void Set_CircleCrossSectionArea(decimal area)
        {
            CircleCrossSection?.Set_Area(area);
        }

        public void Set_SurfaceArea(decimal surfaceArea)
        {
            CircleCrossSection?.Set_r(OtherFunctions.SquareRoot(surfaceArea / (4 * OtherFunctions.PI)));
        }

        public void Set_Volume(decimal volume)
        {
            CircleCrossSection?.Set_r(OtherFunctions.CubeRoot((3 * volume) / (4 * OtherFunctions.PI)));
        }
    }
}
