using BlokMath.Geometry.Shapes;

namespace SuperCalculatorMauiApp.Controls
{
    public partial class SquareView : ContentView
    {
        public SquareView()
        {
            InitializeComponent();

            // set default values
            UpdateObjectValues();
        }

        private void UpdateObjectValues()
        {
            isChanging = true;
            a_Entry.Text = _square.a.ToString();
            d_Entry.Text = _square.d.ToString();
            Circumference_Entry.Text = _square.Circumference.ToString();
            Area_Entry.Text = _square.Area.ToString();
            isChanging = false;
        }

        private bool isChanging = false;

        private Square _square = new Square(1);

        private void a_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if(decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _square.Set_a(result);
                UpdateObjectValues();
            }
        }

        private void d_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result)
                && result != _square.d)
            {
                _square.Set_d(result);
                UpdateObjectValues();
            }
        }

        private void Circumference_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _square.Set_Circumference(result);
                UpdateObjectValues();
            }
        }

        private void Area_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result)
                && result != _square.Area)
            {
                _square.Set_Area(result);
                UpdateObjectValues();
            }
        }
    }
}
