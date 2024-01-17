namespace BlokMath.Functions
{
    public static class TrigonometricFunctions
    {
        #region function by rectangular triangle values

        public static decimal? Sinus(decimal a, decimal c)
        {
            if (c != 0)
                return a / c;
            return null;
        }

        public static decimal? Cosinus(decimal b, decimal c)
        {
            if (c != 0)
                return b / c;
            return null;
        }

        public static decimal? Tangens(decimal a, decimal b)
        {
            if (b != 0)
                return a / b;
            return null;
        }

        public static decimal? Cotangens(decimal a, decimal b)
        {
            if (a != 0)
                return b / a;
            return null;
        }

        #endregion

        #region function by radians

        public static decimal? Sinus(decimal alpha)
        {
            return (decimal)Math.Sin((double)alpha);
        }

        public static decimal? Cosinus(decimal alpha)
        {
            return (decimal)Math.Cos((double)alpha);
        }

        public static decimal? Tangens(decimal alpha)
        {
            return (decimal?)Math.Tan((double)alpha);
        }

        public static decimal? Cotangens(decimal alpha)
        {
            return (decimal?)(Math.Cos((double)alpha) / Math.Sin((double)alpha));
        }

        #endregion
    }
}
