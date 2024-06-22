using BlokMath.Functions;
using Point = BlokMath.Geometry.Shapes.Point;

namespace SuperCalculatorMauiApp.Controls
{
    public partial class LinearFunctionView : ContentView
    {
        public LinearFunctionView()
        {
            InitializeComponent();

            // set default values
            _point = new Point(0, _linearFunction.b);
            UpdateObjectValues();
        }

        private void UpdateObjectValues()
        {
            isChanging = true;

            a_Entry.Text = _linearFunction.a.ToString();
            b_Entry.Text = _linearFunction.b.ToString();
            x0_Entry.Text = _linearFunction.x0.ToString();

            _point.y = _linearFunction.F(_point.x);

            x_Entry.Text = _point.x.ToString();
            y_Entry.Text = _point.y.ToString();

            isChanging = false;
        }

        private bool isChanging = false;

        private LinearFunction _linearFunction = new LinearFunction(1, 0);

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

        private void y_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _point.y = result;
                _point.x = _linearFunction.Get_x(_point.y);

                UpdateObjectValues();
            }
        }

        private void a_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _linearFunction.Set_a(result);
                UpdateObjectValues();
            }
        }

        private void b_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            string entryText = ((Entry)sender).Text;
            if (entryText == string.Empty) entryText = "0";

            if (decimal.TryParse(entryText, out decimal result))
            {
                _linearFunction.Set_b(result);
                UpdateObjectValues();
            }
        }

    }
}
