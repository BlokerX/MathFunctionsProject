namespace BlokMath
{
    internal class GeometricProgression
    {
        public GeometricProgression(float a1, float r)
        {
            this.a1 = a1;
            this.q = r;
        }

        public float a1 { get; private set; }
        public float q { get; private set; }

        public float? a(uint n)
        {
            if (n >= 2)
            {
                float qTemp = q;

                for (int i = 1; i < n; i++)
                    qTemp *= q;

                return a1 * qTemp;
            }
            else if (n == 1) return a1;
            return null;
        }

        public float? S(uint n)
        {
            if(n == 0) return null;

            float qTemp = q;
            for (int i = 1; i < n; i++)
                qTemp *= q;

            if (q != 1)
                return a1 * ((1 - qTemp) / (1 - q));
            else return n * a1;
        }

        public float an(float am, float ao)
        {
            return (float)System.Math.Sqrt(am * ao);
        }
    }
}
