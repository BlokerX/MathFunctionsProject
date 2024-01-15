namespace BlokMath
{
    public static class TrigonometricFunctions
    {
        public static decimal? sin(decimal a, decimal c)
        {
            if (c != 0)
                return a / c;
            return null;
        }

        public static decimal? cos(decimal b, decimal c)
        {
            if (c != 0)
                return b / c;
            return null;
        }

        public static decimal? tg(decimal a, decimal b)
        {
            if (b != 0)
                return a / b;
            return null;
        }

        public static decimal? ctg(decimal a, decimal b)
        {
            if (a != 0)
                return b / a;
            return null;
        }



        public static decimal? sin(decimal alpha)
        {
            return (decimal)Math.Sin((double)alpha);
        }

        public static decimal? cos(decimal alpha)
        {
            return (decimal)Math.Cos((double)alpha);
        }

        public static decimal? tg(decimal alpha)
        {
            return (decimal?)Math.Tan((double)alpha);
        }

        public static decimal? ctg(decimal alpha)
        {
            return (decimal?)(Math.Cos((double)alpha) / Math.Sin((double)alpha));
        }


    }
}
