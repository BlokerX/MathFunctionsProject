using BlokMath.Progressions;

namespace SuperCalculatorMauiApp.Controls
{
    public partial class ArithmeticProgressionView : ContentView
    {
        public ArithmeticProgressionView()
        {
            InitializeComponent();
            // set default values
            UpdateObjectValues();
        }

        private void UpdateObjectValues()
        {
            isChanging = true;

            n_Entry.Text = n.ToString();

            a1_Entry.Text = _arithmeticProgression.a1.ToString();
            d_Entry.Text = _arithmeticProgression.d.ToString();

            an_Entry.Text = _arithmeticProgression.a(n).ToString();

            Sn_Entry.Text = _arithmeticProgression.S(n).ToString();

            isChanging = false;
        }

        private bool isChanging = false;

        private ArithmeticProgression _arithmeticProgression = new ArithmeticProgression(1, 1);

        private uint _n = 1;

        public uint n
        {
            get => _n;
            set
            {
                if (value != 0) _n = value;
                else _n = 1;
            }
        }


        private void a1_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _arithmeticProgression.Set_a1(result);
                UpdateObjectValues();
            }
        }
        
        private void d_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _arithmeticProgression.Set_d(result);
                UpdateObjectValues();
            }
        }
        
        private void n_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (uint.TryParse(((Entry)sender).Text, out uint result))
            {
                n = result;
                UpdateObjectValues();
            }
        }

    }
}
