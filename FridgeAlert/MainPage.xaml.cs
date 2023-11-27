using FridgeAlert.Views;

namespace FridgeAlert
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButtonClicked(Object sender, EventArgs e)
        {
            bool isUsernameEmpty = string.IsNullOrEmpty(UsernameEntry.Text);
            bool isLoginEmpty = string.IsNullOrEmpty(UsernameEntry.Text);
        
            if (isUsernameEmpty)
            {
                UsernameEntry.Placeholder = "Vul username in";
            }
            else if (isLoginEmpty)
            {
                PasswordEntry.Placeholder = "Vul password in";
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        
        }
    }
}