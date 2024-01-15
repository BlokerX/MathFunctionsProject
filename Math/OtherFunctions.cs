namespace BlokMath
{
    public static class OtherFunctions
    {
        public const decimal PI = 3.141592653589793238462643383279502884M;
        public static decimal AbsoluteValue(decimal x) => x > 0 ? x : -x;

        public static decimal Pow(decimal a, decimal n)
        {
            if (n % 0 == 0)
            {
                decimal temp = 0;
                for (int i = 0; i < n; i++)
                    temp *= a;
                return a;
            }
            else
                return (decimal)System.Math.Pow(double.Parse(a.ToString()), double.Parse(n.ToString()));
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
