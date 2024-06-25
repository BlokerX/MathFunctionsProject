using BlokMath.Geometry.Shapes;

namespace SuperCalculatorMauiApp.Controls
{
    public partial class RombusView : ContentView
    {
        public RombusView()
        {
            InitializeComponent();
            UpdateObjectValues();
        }

        private void UpdateObjectValues()
        {
            isChanging = true;

            a_Entry.Text = _robmus.a.ToString();

            h_Entry.Text = _robmus.h.ToString();

            e_Entry.Text = _robmus.e.ToString();
            f_Entry.Text = _robmus.f.ToString();

            alpha_Entry.Text = _robmus.alpha.ToString();
            beta_Entry.Text = _robmus.beta.ToString();

            isChanging = false;
        }

        private bool isChanging = false;

        private Rombus _robmus = new Rombus(1, 1);

        private void a_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _robmus.Set_a(result);
                UpdateObjectValues();
            }
        }

        private void h_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _robmus.Set_h(result);
                UpdateObjectValues();
            }
        }

        private void e_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _robmus.Set_e(result);
                UpdateObjectValues();
            }
        }

        private void f_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _robmus.Set_f(result);
                UpdateObjectValues();
            }
        }

        //private void alpha_Entry_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (isChanging)
        //        return;

        //    if (decimal.TryParse(((Entry)sender).Text, out decimal result))
        //    {
        //        _robmus.Set_alpha(result);
        //        UpdateObjectValues();
        //    }
        //}

        //private void beta_Entry_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (isChanging)
        //        return;

        //    if (decimal.TryParse(((Entry)sender).Text, out decimal result))
        //    {
        //        _robmus.Set_beta(result);
        //        UpdateObjectValues();
        //    }
        //}
    }
}
