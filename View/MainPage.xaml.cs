// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using TuristApp_v2._03.Model;
using TuristApp_v2._03.ViewModel;

namespace TuristApp_v2._03.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.ActualEvent = (Event)((Button)sender).Content;
            this.Frame.Navigate(typeof(DetailedPage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainViewModel.ActualEvent = (Event)((Button)sender).Content;
            this.Frame.Navigate(typeof(DetailedPage));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainViewModel.ActualEvent = (Event)((Button)sender).Content;
            this.Frame.Navigate(typeof(DetailedPage));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainViewModel.ActualEvent = (Event)((Button)sender).Content;
            this.Frame.Navigate(typeof(DetailedPage));
        }
    }
}
