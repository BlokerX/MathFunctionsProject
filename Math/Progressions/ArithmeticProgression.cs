namespace BlokMath.Progressions
{
    public class ArithmeticProgression
    {
        public ArithmeticProgression(decimal a1, decimal r)
        {
            this.a1 = a1;
            this.r = r;
        }

        public decimal a1 { get; private set; }
        public decimal r { get; private set; }

        public decimal? a(uint n)
        {
            if (n >= 1)
                return a1 + (n - 1) * r;
            return null;
        }

        public decimal? S(uint n)
        {
            if (n >= 1)
                return (a1 + a(n)) / 2 * n;
            return null;
        }

        public decimal? an(decimal am, decimal ao)
        {
            return (am + ao) / 2;
        }
    }
}
