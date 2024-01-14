using FridgeAlert.Views;

namespace FridgeAlert
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LoginButtonClicked(Object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomePage");

        }
    }
}