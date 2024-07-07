using BlokMath.Geometry.Solids;

namespace SuperCalculatorMauiApp.Controls
{
    public partial class SphereView : ContentView
    {
        public SphereView()
        {
            InitializeComponent();
            // set default values
            UpdateObjectValues();
        }

        private void UpdateObjectValues()
        {
            isChanging = true;
            r_Entry.Text = _sphere.CircleCrossSection.r.ToString();
            d_Entry.Text = _sphere.CircleCrossSection.d.ToString();
            SurfaceArea_Entry.Text = _sphere.SurfaceArea.ToString();
            Volume_Entry.Text = _sphere.Volume.ToString();
            CircleCrossSectionCircumference_Entry.Text = _sphere.CircleCrossSection.Circumference.ToString();
            CircleCrossSectionArea_Entry.Text = _sphere.CircleCrossSection.Area.ToString();
            isChanging = false;
        }

        private bool isChanging = false;

        private Sphere _sphere = new Sphere(1);

        private void r_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _sphere.Set_r(result);
                UpdateObjectValues();
            }
        }

        private void d_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _sphere.Set_d(result);
                UpdateObjectValues();
            }
        }

        private void Volume_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _sphere.Set_Volume(result);
                UpdateObjectValues();
            }
        }

        private void SurfaceArea_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _sphere.Set_SurfaceArea(result);
                UpdateObjectValues();
            }
        }

        private void CircleCrossSectionCircumference_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _sphere.Set_CircleCrossSectionCircumference(result);
                UpdateObjectValues();
            }
        }

        private void CircleCrossSectionArea_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _sphere.Set_CircleCrossSectionArea(result);
                UpdateObjectValues();
            }
        }
    }
}
