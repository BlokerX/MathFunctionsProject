using BlokMath.Progressions;

namespace SuperCalculatorMauiApp.Controls
{
    public partial class GeometricProgressionView : ContentView
    {
        public GeometricProgressionView()
        {
            InitializeComponent();

            // set default values
            UpdateObjectValues();
        }

        private void UpdateObjectValues()
        {
            isChanging = true;

            n_Entry.Text = n.ToString();

            a1_Entry.Text = _geometicProgression.a1.ToString();
            r_Entry.Text = _geometicProgression.r.ToString();

            an_Entry.Text = _geometicProgression.a(n).ToString();

            Sn_Entry.Text = _geometicProgression.S(n).ToString();

            isChanging = false;
        }

        private bool isChanging = false;

        private GeometricProgression _geometicProgression = new GeometricProgression(1, 1);

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
                _geometicProgression.Set_a1(result);
                UpdateObjectValues();
            }
        }

        private void r_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _geometicProgression.Set_r(result);
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
