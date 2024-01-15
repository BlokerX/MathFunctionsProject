namespace BlokMath
{
    public class ArithmeticProgression
    {
        public ArithmeticProgression(float a1, float r)
        {
            this.a1 = a1;
            this.r = r;
        }

        public float a1 { get; private set; }
        public float r { get; private set; }

        public float? a(uint n)
        {
            if(n >= 1)
            return a1 + ((n - 1) * r);
            return null;
        }

        public float? S(uint n)
        {
            if(n >= 1)
            return ((a1 + a(n)) / 2) * n;
            return null;
        }

        public float? an(float am, float ao)
        {
            return (am + ao) / 2;
        }
    }
}
