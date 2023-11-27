using FridgeAlert.Views;
namespace FridgeAlert
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new MainPage());
        }
    }
}