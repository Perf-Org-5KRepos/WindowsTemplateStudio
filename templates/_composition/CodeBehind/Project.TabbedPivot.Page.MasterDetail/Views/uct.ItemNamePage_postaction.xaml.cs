using Windows.UI.Xaml;
namespace ItemNamespace.Views
{
    public sealed partial class uct.ItemNamePage : Page, INotifyPropertyChanged
    {
        public uct.ItemNamePage()
        {
            Loaded += OnLoaded;
            InitializeComponent();
        }

        //{[{
        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            await LoadDataAsync();
        }
        //}]}
    }
}
