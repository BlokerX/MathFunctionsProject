namespace BlokMath.Progressions
{
    public class GeometricProgression
    {
        public GeometricProgression(decimal a1, decimal r)
        {
            this.a1 = a1;
            this.r = r;
        }

        public decimal a1 { get; private set; }
        public decimal r { get; private set; }

        public decimal? a(uint n)
        {
            if (n >= 2)
            {
                decimal qTemp = r;

                for (int i = 1; i < n; i++)
                    qTemp *= r;

                return a1 * qTemp;
            }
            else if (n == 1) return a1;
            return null;
        }

        public decimal? S(uint n)
        {
            if (n == 0) return null;

            decimal qTemp = r;
            for (int i = 1; i < n; i++)
                qTemp *= r;

            if (r != 1)
                return a1 * ((1 - qTemp) / (1 - r));
            else return n * a1;
        }

        public decimal an(decimal am, decimal ao)
        {
            return (decimal)Math.Sqrt(double.Parse(am.ToString()) * double.Parse(ao.ToString()));
        }

        public void Set_r(decimal r)
        {
            this.r = r;
        }

        public void Set_a1(decimal a1)
        {
            this.a1 = a1;
        }
    }
}
