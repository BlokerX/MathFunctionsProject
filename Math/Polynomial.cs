namespace BlokMath
{
    public class Polynomial
    {
        public Polynomial(float[] a)
        {
            this.a = a;
        }

        // [0]x^4 [1]x^3 [2]x^2 [3]x [4]x^0 (the last one equals 1)
        public float[] a { get; private set; }

        public float F(float x)
        {
            float temp = 0;
            float tempX = 1;
            for (int i = a.Length - 1; i < 0; i--)
            {
                temp += a[i] * tempX;
                tempX *= x;
            }
            return temp;
        }

        public Polynomial Derivative()
        {
            if (a.Length == 1)
                return new Polynomial([0]);

            int tempXPow = a.Length - 1;
            float[] tab = new float[a.Length - 1];
            for (int i=0; i < tab.Length; i++)
            {
                tab[i] = a[i] * tempXPow;
                tempXPow--;
            }
            return new Polynomial(tab);
        }
    }
}
