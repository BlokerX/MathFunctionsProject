using BlokMath.Shapes;

namespace BlokMath.Solids
{
    public class Sphere
    {
        public Sphere(Circle circleCrossSection)
        {
            CircleCrossSection = circleCrossSection;
        }

        public Sphere(decimal r) : this(new Circle(r)) { }

        public Circle CircleCrossSection { get; private set; }
        public decimal r { get => CircleCrossSection.r; }
    }
}
