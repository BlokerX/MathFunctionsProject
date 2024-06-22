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

        public void Set_a(decimal a)
        {
            this.a = a;
        }

        public void Set_b(decimal b)
        {
            this.b = b;
        }

        public decimal Get_x(decimal y)
        {
            if (a != 0) return (y - b) / a;
            else return 0;
        }

        public decimal Derivative() => a;

        public Polynomial ToPolynomial => new Polynomial([a, b]);
    }
}
