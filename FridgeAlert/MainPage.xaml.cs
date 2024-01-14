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
            bool isUsernameEmpty = string.IsNullOrEmpty(UsernameEntry.Text);
            bool isLoginEmpty = string.IsNullOrEmpty(UsernameEntry.Text);

            if (isUsernameEmpty)
            {
                UsernameEntry.Placeholder = "You forgot to enter a username!";
            }
            else if (isLoginEmpty)
            {
                PasswordEntry.Placeholder = "You forgot to enter a password!";
            }
            else
            {
                await Shell.Current.GoToAsync("//HomePage");
            }

        }

        private async void RegisterButtonClicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }
    }
}