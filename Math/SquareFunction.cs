namespace BlokMath
{
    public class SquareFunction
    {
        public void SquareFunctionBuildAsGeneral(float a, float b, float c)
        {
            //if (a == 0)
            //    return;

            this.a = a;
            this.b = b;
            this.c = c;

            this.W = new Point(((-b) / 2 * a), ((-Delta) / 4 * b));
        }

        public void SquareFunctionBuildAsCanonical(float a, float p, float q)
        {
            this.a = a;
            this.W = new Point(p, q);

            this.b = -2 * a * p;
            this.c = (-(b * b) + (-4 * a * q)) / (-4 * a);
        }

        public void SquareFunctionBuildAsFactored(float a, float x1, float x2)
        {
            this.a = a;
            //this.x1 = x1;
            //this.x2 = x2;

            this.b = -(x1 + x2) * a;
            this.c = (x1 * x2) * a;

            this.W = new Point(((-b) / 2 * a), ((-Delta) / 4 * b));
        }

        public void SquareFunctionBuildAsFactored(float a, float x0)
        {
            //this.x0 = x0;
            SquareFunctionBuildAsFactored(a, x0, x0);
        }

        #region General form
        public float a { get; private set; }
        public float b { get; private set; }
        public float c { get; private set; }

        #endregion

        #region Canonical form

        public Point W { get; private set; }

        public float p
        {
            get
            {
                return W.x;
            }
            private set
            {
                W.x = value;
            }
        }

        public float q
        {
            get
            {
                return W.y;
            }
            private set
            {
                W.y = value;
            }
        }

        #endregion

        #region Factored form

        public float? x0
        {
            get
            {
                if (Delta == 0)
                    return (-b) / (2 * a);
                //or
                //if(q == 0)
                return null;
            }
        }

        public float? x1
        {
            get
            {
                if (Delta > 0)
                    return (-b - DeltaSqrt) / (2 * a);
                else return x0;
            }
        }
        public float? x2
        {
            get
            {
                if (Delta > 0)
                    return (-b + DeltaSqrt) / (2 * a);
                else return x0;
            }
        }

        #endregion

        public float Delta { get => (b * b) - (4 * a * c); }
        public float? DeltaSqrt { get => (float?)System.Math.Sqrt(Delta); }

        public float F_GeneralForm(float x)
        {
            return a * (x * x) + b * x + c;
        }

        public float F_CanonicalForm(float x)
        {
            return a * (x - p) * (x - p) + q;
        }

        public float? F_FactoredForm(float x)
        {
            if (x1 != null && x2 != null)
                return a * (x - (float)x1) * (x - (float)x2);
            return null;
        }

        public float F(float x) => F_GeneralForm(x);

        public bool IsHaveMaximum { get { if (a < 0) return true; return false; } }
        public bool IsHaveMinimum { get { if (a > 0) return true; return false; } }

        // Viete:
        // x1 + x2 = -b/a
        // x1 * x2 = c/a

        public LinearFunction Derivative()
        {
            return new LinearFunction(2 * a, b);
        }

        public Polynomial ToPolynomial() => new Polynomial([a, b, c]);
    }
}
