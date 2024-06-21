using BlokMath.Geometry.Shapes;

namespace SuperCalculatorMauiApp.Controls
{
    public partial class RectangleView : ContentView
    {
        public RectangleView()
        {
            InitializeComponent();

            UpdateObjectValues();
        }
        private void UpdateObjectValues()
        {
            isChanging = true;
            a_Entry.Text = _rectangle.a.ToString();
            b_Entry.Text = _rectangle.b.ToString();
            d_Entry.Text = _rectangle.d.ToString();
            Circumference_Entry.Text = _rectangle.Circumference.ToString();
            Area_Entry.Text = _rectangle.Area.ToString();
            isChanging = false;
        }

        private bool isChanging = false;

        private Rectangle _rectangle = new Square(1);

        private void a_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _rectangle.Set_a(result);
                UpdateObjectValues();
            }
        }

        private void b_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _rectangle.Set_b(result);
                UpdateObjectValues();
            }
        }
    }
}
