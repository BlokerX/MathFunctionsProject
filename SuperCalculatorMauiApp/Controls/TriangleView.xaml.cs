using BlokMath.Geometry.Shapes;

namespace SuperCalculatorMauiApp.Controls
{
    public partial class TriangleView : ContentView
    {
        public TriangleView()
        {
            InitializeComponent();
            // set default values
            UpdateObjectValues();
        }

        private void UpdateObjectValues()
        {
            isChanging = true;

            a_Entry.Text = _triangle.a.ToString();
            b_Entry.Text = _triangle.b.ToString();
            c_Entry.Text = _triangle.c.ToString();
            
            h_a_Entry.Text = _triangle.a_h.ToString();
            h_b_Entry.Text = _triangle.b_h.ToString();
            h_c_Entry.Text = _triangle.c_h.ToString();
            
            alpha_Entry.Text = _triangle.alpha.ToString();
            beta_Entry.Text = _triangle.beta.ToString();
            gamma_Entry.Text = _triangle.gamma.ToString();

            Circumference_Entry.Text = _triangle.Circumference.ToString();
            Area_Entry.Text = _triangle.Area.ToString();
            isChanging = false;
        }

        private bool isChanging = false;

        private Triangle _triangle = new Triangle(1,1,1, Triangle.TriangleBuildType.a_b_c_TriangleBuild);


        private void a_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _triangle.Set_a(result);
                UpdateObjectValues();
            }
        }

        private void b_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _triangle.Set_b(result);
                UpdateObjectValues();
            }
        }

        private void c_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _triangle.Set_c(result);
                UpdateObjectValues();
            }
        }



        private void h_a_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void h_b_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void h_c_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void alpha_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void beta_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void gamma_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
