namespace SuperCalculatorMauiApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DonateButton_Clicked(object sender, EventArgs e)
        {
            var b = (Button)sender;
            b.Text = "😊 Thank you for the donation 😊";
            b.BackgroundColor = Microsoft.Maui.Graphics.Color.FromRgb(246, 250, 185);

            try
            {
                Uri uri = new("https://www.github.com/BlokerX");
                Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch /*(Exception ex)*/
            {
                b.Text = "Somethink has gone wrong, try again";
                b.BackgroundColor = Microsoft.Maui.Graphics.Color.FromRgb(255, 100, 100);
            }
        }
    }

}
