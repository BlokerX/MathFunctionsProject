using BlokMath.Geometry.Shapes;

namespace SuperCalculatorMauiApp.Controls
{
    public partial class CircleView : ContentView
    {
        public CircleView()
        {
            InitializeComponent();

            // set default values
            UpdateObjectValues();
        }

        private void UpdateObjectValues()
        {
            isChanging = true;
            r_Entry.Text = _circle.r.ToString();
            d_Entry.Text = _circle.d.ToString();
            Circumference_Entry.Text = _circle.Circumference.ToString();
            Area_Entry.Text = _circle.Area.ToString();
            isChanging = false;
        }

        private bool isChanging = false;

        private Circle _circle = new Circle(1);

        private void r_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _circle.Set_r(result);
                UpdateObjectValues();
            }
        }

        private void d_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _circle.Set_d(result);
                UpdateObjectValues();
            }
        }

        private void Circumference_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _circle.Set_Circumference(result);
                UpdateObjectValues();
            }
        }

        private void Area_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _circle.Set_Area(result);
                UpdateObjectValues();
            }
        }
    }
}
