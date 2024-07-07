using BlokMath.Functions;

namespace BlokMath.Geometry.Shapes
{
    public class Rombus
    {
        public Rombus(decimal e, decimal f)
        {
            this.e = e;
            this.f = f;

            Set_e_Or_f();
        }

        //public Rombus(decimal a, decimal h)
        //{

        //}

        public decimal a { get; private set; }

        public decimal h { get; private set; }

        public decimal e { get; private set; }
        public decimal f { get; private set; }

        public decimal alpha
        {
            get
            {
                // Przekątne dzielą romb na cztery trójkąty prostokątne
                decimal half_e = e / 2;
                decimal half_f = f / 2;

                // Oblicz kąt alpha używając arctangens
                // Zamieniamy wyniki z radianów na stopnie
                double alphaRad = Math.Atan((double)(half_f / half_e));
                return (decimal)(alphaRad * (180.0 / Math.PI));
            }
        }

        public decimal beta
        {
            get
            {
                // Przekątne dzielą romb na cztery trójkąty prostokątne
                decimal half_e = e / 2;
                decimal half_f = f / 2;

                // Oblicz kąt beta używając arctangens
                // Zamieniamy wyniki z radianów na stopnie
                double alphaRad = Math.Atan((double)(half_e / half_f));
                return (decimal)(alphaRad * (180.0 / Math.PI));
            }
        }

        public void Set_a(decimal a)
        {
            this.a = a;
            Set_a_Or_h();
        }

        public void Set_h(decimal h)
        {
            this.h = h;
            Set_a_Or_h();
        }

        private void Set_a_Or_h()
        {
            // Sprawdzenie, czy podane wartości są poprawne
            if (a <= 0 || h <= 0 || h >= 2 * a)
            {
#if DEBUG
                //todo throw new ArgumentException("Podane wartości boku i wysokości są nieprawidłowe.");
#endif
                return;
            }

            #region e_Oraz_f

            // Oblicz e * f
            decimal ef = 2 * a * h;

            // Oblicz e^2 + f^2
            decimal e2_plus_f2 = 4 * a * a;

            // Rozwiązujemy układ równań
            // e = sqrt((e2_plus_f2 + sqrt(e2_plus_f2^2 - 4 * ef^2)) / 2)
            // f = ef / e

            decimal discriminant = OtherFunctions.SquareRoot(e2_plus_f2 * e2_plus_f2 - 4 * ef * ef);
            e = OtherFunctions.SquareRoot((e2_plus_f2 + discriminant) / 2);
            f = ef / e;

            #endregion
        }

        public void Set_e(decimal e)
        {
            this.e = e;
            Set_e_Or_f();
        }

        public void Set_f(decimal f)
        {
            this.f = f;
            Set_e_Or_f();
        }

        private void Set_e_Or_f()
        {
            // Sprawdzenie, czy podane wartości są poprawne
            if (e <= 0 || f <= 0)
            {
#if DEBUG
                //todo throw new ArgumentException("Podane wartości przekątnych są nieprawidłowe.");
#endif
                return;
            }

            a = OtherFunctions.SquareRoot(OtherFunctions.Power(e / 2, 2) + OtherFunctions.Power(f / 2, 2));
            h = ((e * f) / 2) / a;
        }

        //public void Set_alpha(decimal alpha)
        //{
        //    this.alpha = alpha;
        //}
        //public void Set_beta(decimal beta)
        //{
        //    this.beta = beta;
        //}

        public void Set_Circumference(decimal circumference)
        {
            if (circumference != 0)
                a = circumference / 4;
            else a = 0;
        }

        public decimal Area => a * h; // todo (e*f)/2

        public decimal Circumference => a * 4;
    }
}
