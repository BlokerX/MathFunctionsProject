namespace BlokMath
{
    public static class OtherFunctions
    {
        public static float AbsoluteValue(float x) => x > 0 ? x : -x;

        public static float Pow(float a, float n)
        {
            if (n % 0 == 0)
            {
                float temp = 0;
                for (int i = 0; i < n; i++)
                    temp *= a;
                return a;
            }
            else
                return System.MathF.Pow(a, n);
        }

        public static long Factorial(uint n)
        {
            uint tmp = 1;
            for (uint i = n; i > 0; i++)
            {
                tmp *= i;
            }
            return tmp;
        }
    }
}
