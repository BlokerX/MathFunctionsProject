using BlokMath.Functions;
using Point = BlokMath.Geometry.Shapes.Point;

namespace SuperCalculatorMauiApp.Controls
{
    public partial class SquareFunctionView : ContentView
    {
        public SquareFunctionView()
        {
            InitializeComponent();

            //todo zmienic
            _squareFunction.SquareFunctionBuildAsGeneral(1,0,0);

            // set default values
            _point = new Point(0, _squareFunction.c);
            UpdateObjectValues();
        }

        private void UpdateObjectValues()
        {
            isChanging = true;

            a_Entry.Text = _squareFunction.a.ToString();
            b_Entry.Text = _squareFunction.b.ToString();
            c_Entry.Text = _squareFunction.c.ToString();

            p_Entry.Text = _squareFunction.p.ToString();
            q_Entry.Text = _squareFunction.q.ToString();

            Delta_Entry.Text = _squareFunction.Delta.ToString();
            DeltaSquareRoot_Entry.Text = _squareFunction.DeltaSqrt.ToString();

            x0_Entry.Text = _squareFunction.x0.ToString();
            x1_Entry.Text = _squareFunction.x1.ToString();
            x2_Entry.Text = _squareFunction.x2.ToString();

            _point.y = _squareFunction.F(_point.x);

            x_Entry.Text = _point.x.ToString();
            y_Entry.Text = _point.y.ToString();

            isChanging = false;
        }

        private bool isChanging = false;

        private SquareFunction _squareFunction = new SquareFunction();

        private Point _point;

        private void x_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _point.x = result;
                // todo moved to update : _point.y = _linearFunction.F(_point.x);

                UpdateObjectValues();
            }
        }

        private void a_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _squareFunction.Set_a(result);
                UpdateObjectValues();
            }
        }

        private void b_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _squareFunction.Set_b(result);
                // todo dodac build generalny
                UpdateObjectValues();
            }
        }

        private void c_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _squareFunction.Set_c(result);
                // todo dodac build generalny
                UpdateObjectValues();
            }
        }

        private void p_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _squareFunction.Set_p(result);
                // todo dodac build generalny
                UpdateObjectValues();
            }
        }

        private void q_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _squareFunction.Set_q(result);
                // todo dodac build generalny
                UpdateObjectValues();
            }
        }

        private void x0_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _squareFunction.Set_x0(result);
                UpdateObjectValues();
            }
        }

        private void x1_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _squareFunction.Set_x1(result);
                UpdateObjectValues();
            }
        }

        private void x2_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _squareFunction.Set_x2(result);
                UpdateObjectValues();
            }
        }
    }
}
