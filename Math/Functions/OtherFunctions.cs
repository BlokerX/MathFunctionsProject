namespace BlokMath.Functions
{
    public static class OtherFunctions
    {
        public const decimal PI = 3.141592653589793238462643383279502884M;
        public const decimal EulerNumber = 2.71828182845904523536M;

        public static decimal AbsoluteValue(decimal x) => x > 0 ? x : -x;

        public static decimal Power(decimal a, decimal n)
        {
            if (n == 0)
                return 1;
            if (a == 0)
                return 0;
            if (a == 1)
                return 1;


            if (n != 1)
                return a * Power(a, n - 1);
            else return a;
        }

        public static decimal SquareRoot(decimal a, decimal precision = 0.0000000001m)
        {
            if (a < 0)
            {
                throw new ArgumentException("Number must be non-negative.");
            }
            else if (a == 1) return 1;

            decimal guess = a / 2;
            while (AbsoluteValue(guess * guess - a) > precision)
            {
                guess = (guess + a / guess) / 2;
            }
            return guess;
        }

        public static decimal CubeRoot(decimal a, decimal precision = 0.0000000001m)
        {
            if (a < 0)
            {
                return -CubeRoot(-a, precision);
            }
            else if (a == 1) return 1;

            decimal guess = a / 3;
            while (AbsoluteValue(guess * guess * guess - a) > precision)
            {
                guess = (2 * guess + a / (guess * guess)) / 3;
            }
            return guess;
        }

        public static decimal NthRoot(decimal number, decimal n, decimal precision = 0.00000000000001m)
        {
            // todo nie działa
            if (number < 0 && n % 2 == 0)
            {
                throw new ArgumentException("Even root of a negative number is not real.");
            }

            decimal guess = number / n;
            while (AbsoluteValue(Power(guess, n) - number) > precision)
            {
                guess = ((n - 1) * guess + number / Power(guess, n - 1)) / n;
            }
            return guess;
        }

        public static long Factorial(uint n)
        {
            if (n < 0)
                throw new ArgumentException("Number must be non-negative.");
            if (n == 0)
                return 0;

            uint tmp = 1;
            for (uint i = n; i > 0; i--)
            {
                tmp *= i;
            }
            return tmp;
        }

    }
}
