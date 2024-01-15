namespace BlokMath
{
    internal class GeometricProgression
    {
        public GeometricProgression(decimal a1, decimal r)
        {
            this.a1 = a1;
            this.q = r;
        }

        public decimal a1 { get; private set; }
        public decimal q { get; private set; }

        public decimal? a(uint n)
        {
            if (n >= 2)
            {
                decimal qTemp = q;

                for (int i = 1; i < n; i++)
                    qTemp *= q;

                return a1 * qTemp;
            }
            else if (n == 1) return a1;
            return null;
        }

        public decimal? S(uint n)
        {
            if(n == 0) return null;

            decimal qTemp = q;
            for (int i = 1; i < n; i++)
                qTemp *= q;

            if (q != 1)
                return a1 * ((1 - qTemp) / (1 - q));
            else return n * a1;
        }

        public decimal an(decimal am, decimal ao)
        {
            return (decimal)System.Math.Sqrt(Double.Parse(am.ToString()) * Double.Parse(ao.ToString()));
        }
    }
}
