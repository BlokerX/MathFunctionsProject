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
            b.BackgroundColor = Color.FromRgb(246, 250, 185);

            try
            {
                Uri uri = new("https://www.github.com/BlokerX");
                Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch /*(Exception ex)*/
            {
                b.Text = "Somethink has gone wrong, try again";
                b.BackgroundColor = Color.FromRgb(255, 100, 100);
            }
        }
    }

}
