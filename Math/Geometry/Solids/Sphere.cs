﻿using BlokMath.Functions;
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

        public decimal SurfaceArea() => 4 * OtherFunctions.PI * r * r;
        public decimal Volume() => r * r * 4 / 3 * OtherFunctions.PI;
    }
}
