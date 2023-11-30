using FridgeAlert.Views;
namespace FridgeAlert
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            //MainPage = new MainPage();
            //MainPage = new NavigationPage(new MainPage());
            MainPage = new AppShell();
           
        }
    }
}