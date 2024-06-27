namespace SuperCalculatorMauiApp.Controls
{
    public partial class TemplateForSuperCalculatorControlView : ContentView
    {
        public TemplateForSuperCalculatorControlView()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private string _imgSrc = "";

        public string ImgSrc
        {
            get => _imgSrc;
            set
            {
                _imgSrc = value;
                OnPropertyChanged(nameof(ImgSrc));
            }
        }


        private string _objectTypeName = "";

        public string ObjectTypeName
        {
            get => _objectTypeName;
            set
            {
                _objectTypeName = value;
                OnPropertyChanged(nameof(ObjectTypeName));
            }
        }
        #region Zapasowe
        //public static readonly BindableProperty ObjectTypeNameProperty =
        //    BindableProperty.Create(nameof(ObjectTypeName), typeof(string), typeof(TemplateForSuperCalculatorControlView), string.Empty);

        //public string ObjectTypeName
        //{
        //    get { return (string)GetValue(ObjectTypeNameProperty); }
        //    set { SetValue(ObjectTypeNameProperty, value); }
        //}
        #endregion


        private int _propertiesCount;

        public int PropertiesCount
        {
            get => _propertiesCount;
            set
            {
                _propertiesCount = value;
                OnPropertyChanged(nameof(PropertiesCount));
            }
        }

        public Grid GridWithProperties
        {
            get => _GridWithProperties;
            set
            {
                _GridWithProperties = value;
                OnPropertyChanged(nameof(GridWithProperties));
            }
        }
    }
}
