using BlokMath.Geometry.Solids;

namespace SuperCalculatorMauiApp.Controls
{
    public partial class CubeView : ContentView
    {
        public CubeView()
        {
            InitializeComponent();
            // set default values
            UpdateObjectValues();
        }

        private void UpdateObjectValues()
        {
            isChanging = true;
            a_Entry.Text = _cube.a.ToString();
            MainDiagonal_Entry.Text = _cube.MainDiagonal.ToString();
            LateralSurfaceArea_Entry.Text = _cube.LateralSurfaceArea.ToString();
            TotalSurfaceArea_Entry.Text = _cube.TotalSurfaceArea.ToString();
            Volume_Entry.Text = _cube.Volume.ToString();
            DiagonalOfFaceOfCube_Entry.Text = _cube.Face().d.ToString();
            SurfaceAreaOfFace_Entry.Text = _cube.Face().Area.ToString();
            
            isChanging = false;
        }

        private bool isChanging = false;

        private Cube _cube = new Cube(1);

        private void a_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _cube.Set_a(result);
                UpdateObjectValues();
            }
        }

        private void MainDiagonal_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _cube.Set_MainDiagonal(result);
                UpdateObjectValues();
            }
        }

        private void LateralSurfaceArea_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _cube.Set_LateralSurfaceArea(result);
                UpdateObjectValues();
            }
        }

        private void TotalSurfaceArea_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _cube.Set_TotalSurfaceArea(result);
                UpdateObjectValues();
            }
        }

        private void Volume_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging == true)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _cube.Set_Volume(result);
                UpdateObjectValues();
            }
        }

        private void DiagonalOfFaceOfCube_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _cube.Set_DiagonalOfFaceOfCube(result);
                UpdateObjectValues();
            }
        }

        private void SurfaceAreaOfFace_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanging)
                return;

            if (decimal.TryParse(((Entry)sender).Text, out decimal result))
            {
                _cube.Set_SurfaceAreaOfFace(result);
                UpdateObjectValues();
            }
        }
    }
}
