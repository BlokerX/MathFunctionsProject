using BlokMath.Geometry.Shapes;

namespace SuperCalculatorMauiApp.Controls
{
    public partial class SquareView : ContentView
    {
        public SquareView()
        {
            InitializeComponent();

            // set default values
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
            isChanging = true;

            if(decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                //todo zamiana wartosci
            }

            isChanging = false;
        }

        private void d_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;
            isChanging = true;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                //todo zamiana wartosci
            }

            isChanging = false;
        }

        private void Circumference_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;
            isChanging = true;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                //todo zamiana wartosci
            }

            isChanging = false;
        }

        private void Area_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;
            isChanging = true;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                //todo zamiana wartosci
            }

            isChanging = false;
        }
    }
}
