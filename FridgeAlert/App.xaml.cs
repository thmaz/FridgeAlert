using FridgeAlert.Views;
using sqlite;
using System.Security.Cryptography.X509Certificates;

namespace FridgeAlert
{
    public partial class App : Application
    {
        public static UserRepository? UserRepo { get; private set; }
        public App(UserRepository userRepo)
        {
            InitializeComponent();

            UserRepo = userRepo;
            MainPage = new AppShell();
           
        }
    }
}