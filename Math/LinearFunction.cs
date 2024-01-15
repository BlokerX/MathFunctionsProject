namespace BlokMath
{
    public class LinearFunction
    {
        public LinearFunction(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public float a { get; private set; }
        public float b { get; private set; }

        public float? x0
        {
            get
            {
                if (a != 0) return -b / a;
                return null;
            }
        }

        public float F(float x) => a * x + b;

        public float Derivative() => a;

        public Polynomial ToPolynomial => new Polynomial([a, b]);
    }
}
