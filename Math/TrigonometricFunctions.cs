namespace BlokMath
{
    public static class TrigonometricFunctions
    {
        public static float? sin(float a, float c)
        {
            if (c != 0)
                return a / c;
            return null;
        }

        public static float? cos(float b, float c)
        {
            if (c != 0)
                return b / c;
            return null;
        }

        public static float? tg(float a, float b)
        {
            if (b != 0)
                return a / b;
            return null;
        }

        public static float? ctg(float a, float b)
        {
            if (a != 0)
                return b / a;
            return null;
        }



        public static float? sin(float alpha)
        {
            return (float)Math.Sin(alpha);
        }

        public static float? cos(float alpha)
        {
            return (float)Math.Cos(alpha);
        }

        public static float? tg(float alpha)
        {
            return (float?)Math.Tan(alpha);
        }

        public static float? ctg(float alpha)
        {
            return (float?)(Math.Cos(alpha) / Math.Sin(alpha));
        }


    }
}
