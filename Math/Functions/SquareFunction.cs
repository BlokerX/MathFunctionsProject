using BlokMath.Geometry.Shapes;

namespace BlokMath.Functions
{
    public class SquareFunction
    {
        public void SquareFunctionBuildAsGeneral(decimal a, decimal b, decimal c)
        {
            //if (a == 0)
            //    return;

            this.a = a;
            this.b = b;
            this.c = c;

            W = new Point(-b / 2 * a, -Delta / 4 * b);
        }

        public void SquareFunctionBuildAsCanonical(decimal a, decimal p, decimal q)
        {
            this.a = a;
            W = new Point(p, q);

            b = -2 * a * p;
            c = (-(b * b) + -4 * a * q) / (-4 * a);
        }

        public void SquareFunctionBuildAsFactored(decimal a, decimal x1, decimal x2)
        {
            this.a = a;
            //this.x1 = x1;
            //this.x2 = x2;

            b = -(x1 + x2) * a;
            c = x1 * x2 * a;

            W = new Point(-b / 2 * a, -Delta / 4 * b);
        }

        public void SquareFunctionBuildAsFactored(decimal a, decimal x0)
        {
            //this.x0 = x0;
            SquareFunctionBuildAsFactored(a, x0, x0);
        }

        #region General form
        public decimal a { get; private set; }
        public decimal b { get; private set; }
        public decimal c { get; private set; }

        #endregion

        #region Canonical form

        public Point W { get; private set; }

        public decimal p
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

        public decimal q
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

        public decimal? x0
        {
            get
            {
                if (Delta == 0)
                    return -b / (2 * a);
                //or
                //if(q == 0)
                return null;
            }
        }

        public decimal? x1
        {
            get
            {
                if (Delta > 0)
                    return (-b - DeltaSqrt) / (2 * a);
                else return null;
            }
        }
        public decimal? x2
        {
            get
            {
                if (Delta > 0)
                    return (-b + DeltaSqrt) / (2 * a);
                else return null;
            }
        }

        #endregion

        public decimal Delta { get => b * b - 4 * a * c; }
        public decimal? DeltaSqrt
        {
            get
            {
                if (Delta < 0)
                    return null;

                return OtherFunctions.SquareRoot(Delta);
            }
        }

        public decimal F_GeneralForm(decimal x)
        {
            return a * x * x + b * x + c;
        }

        public decimal F_CanonicalForm(decimal x)
        {
            return a * (x - p) * (x - p) + q;
        }

        public decimal? F_FactoredForm(decimal x)
        {
            if (x1 != null && x2 != null)
                return a * (x - (decimal)x1) * (x - (decimal)x2);
            return null;
        }

        public decimal F(decimal x) => F_GeneralForm(x);

        public void Set_a(decimal a)
        {
            if (a != 0)
                SquareFunctionBuildAsGeneral(a, b, c);
        }

        public void Set_b(decimal b)
        {
            if (a != 0)
                SquareFunctionBuildAsGeneral(a, b, c);
        }

        public void Set_c(decimal c)
        {
            if (a != 0)
                SquareFunctionBuildAsGeneral(a, b, c);
        }

        public void Set_p(decimal p)
        {
            if (a != 0)
                SquareFunctionBuildAsCanonical(a, p, q);
        }

        public void Set_q(decimal q)
        {
            if (a != 0)
                SquareFunctionBuildAsCanonical(a, p, q);
        }

        public void Set_x0(decimal x0)
        {
            if (a != 0)
                SquareFunctionBuildAsFactored(a, x0);
        }

        public void Set_x1(decimal x1)
        {
            if (a != 0 && x2 != null)
                SquareFunctionBuildAsFactored(a, x1, (decimal)x2);
        }

        public void Set_x2(decimal x2)
        {
            if (a != 0 && x1 != null)
                SquareFunctionBuildAsFactored(a, (decimal)x1, x2);
        }

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
