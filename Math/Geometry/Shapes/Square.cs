﻿namespace BlokMath.Geometry.Shapes
{
    public class Square : Rectangle
    {
        public Square(decimal a) : base(a, a) { }

        public new decimal a
        {
            get => base.a;
            protected set => base.a = b = value;
        }
    }
}
