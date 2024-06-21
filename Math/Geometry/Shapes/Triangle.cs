using BlokMath.Functions;

namespace BlokMath.Geometry.Shapes
{
    public class Triangle
    {
        public Triangle(decimal a_parameter, decimal b_parameter, decimal c_parameter, TriangleBuildType triangleBuildType)
        {
            _buildType = triangleBuildType;

            switch (triangleBuildType)
            {
                case TriangleBuildType.a_b_c_TriangleBuild:
                    Build_a_b_c_Triangle(a_parameter, b_parameter, c_parameter);
                    return;

                case TriangleBuildType.h_a_h_b_h_c_TriangleBuild:
                    a_h = a_parameter;
                    b_h = b_parameter;
                    c_h = c_parameter;
                    return;

                case TriangleBuildType.alpha_beta_gamma_TriangleBuild:
                    alpha = a_parameter;
                    beta = b_parameter;
                    gamma = c_parameter;
                    return;
            }
        }

        public void Build_a_b_c_Triangle(decimal a, decimal b, decimal c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            a_h = CalculateHeight(a, b, c);
            b_h = CalculateHeight(b, c, a);
            c_h = CalculateHeight(c, a, b);

            var angles = CalculateAngles(a, b, c);
            alpha = angles.alpha;
            beta = angles.beta;
            gamma = angles.gamma;
        }

        #region helper
        private static decimal CalculateHeight(decimal a, decimal b, decimal c)
        {
            // Sprawdzamy, czy trójkąt o podanych bokach może istnieć
            if (a <= 0 || b <= 0 || c <= 0 || (a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                throw new ArgumentException("Podane długości boków nie tworzą trójkąta.");
            }

            // Obliczamy połowę obwodu trójkąta
            decimal s = (a + b + c) / 2;

            // Obliczamy pole trójkąta za pomocą wzoru Herona
            decimal area = OtherFunctions.SquareRoot(s * (s - a) * (s - b) * (s - c));

            // Obliczamy wysokość ha
            decimal ha = (2 * area) / a;

            return ha;
        }

        public static (decimal alpha, decimal beta, decimal gamma) CalculateAngles(decimal a, decimal b, decimal c)
        {
            // Sprawdzamy, czy trójkąt o podanych bokach może istnieć
            if (a <= 0 || b <= 0 || c <= 0 || (a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                throw new ArgumentException("Podane długości boków nie tworzą trójkąta.");
            }

            // Obliczamy kąty za pomocą prawa kosinusów
            decimal alpha = (decimal)(Math.Acos((double)((b * b + c * c - a * a) / (2 * b * c))) * (180.0 / Math.PI));
            decimal beta = (decimal)(Math.Acos((double)((a * a + c * c - b * b) / (2 * a * c))) * (180.0 / Math.PI));
            decimal gamma = (decimal)(Math.Acos((double)((a * a + b * b - c * c) / (2 * a * b))) * (180.0 / Math.PI));

            return (alpha, beta, gamma);
        }

        #endregion

        private TriangleBuildType _buildType;

        public decimal a { get; private set; }
        public decimal b { get; private set; }
        public decimal c { get; private set; }

        public decimal a_h { get; private set; }
        public decimal b_h { get; private set; }
        public decimal c_h { get; private set; }

        public decimal alpha { get; private set; }
        public decimal beta { get; private set; }
        public decimal gamma { get; private set; }

        //a=Sqrt((c*c)-(b*b))

        public decimal Area => (((a * a_h) / 2) + ((b * b_h) / 2) + ((c * c_h) / 2))/3;

        public decimal Circumference => a + b + c;

        public enum TriangleBuildType
        {
            a_b_c_TriangleBuild,
            h_a_h_b_h_c_TriangleBuild,
            alpha_beta_gamma_TriangleBuild,
            // todo triangle in circle
            // todo triangle on circle
        }

        public enum TriangleType
        {
            EquilateralTriangle,// rownoboczny
            IsoscelesTriangle, // rownoramienny
            RightTriangle, // prostokątny
            ScaleneTriangle, // roznoboczny
        }
    }
}
