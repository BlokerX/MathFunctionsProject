namespace BlokMath.Functions
{
    public class LinearFunction
    {
        public LinearFunction(decimal a, decimal b)
        {
            this.a = a;
            this.b = b;
        }

        public decimal a { get; private set; }
        public decimal b { get; private set; }

        public decimal? x0
        {
            get
            {
                if (a != 0) return -b / a;
                return null;
            }
        }

        public decimal F(decimal x) => a * x + b;

        public decimal Derivative() => a;

        public Polynomial ToPolynomial => new Polynomial([a, b]);
    }
}
