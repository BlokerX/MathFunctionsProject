namespace BlokMath.Progressions
{
    public class ArithmeticProgression
    {
        public ArithmeticProgression(decimal a1, decimal d)
        {
            this.a1 = a1;
            this.d = d;
        }

        public decimal a1 { get; private set; }
        public decimal d { get; private set; }

        public decimal? a(uint n)
        {
            if (n >= 1)
                return a1 + (n - 1) * d;
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

        public void Set_d(decimal d)
        {
            this.d = d;
        }
        
        public void Set_a1(decimal a1)
        {
            this.a1 = a1;
        }
    }
}
