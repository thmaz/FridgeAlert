using sqlite;

namespace FridgeAlert
{
    public partial class App : Application
    {
        public static FridgeRepository? FridgeRepo { get; private set; }
        public App(FridgeRepository fridgeRepository)
        {
            InitializeComponent();

            FridgeRepo = fridgeRepository;
            MainPage = new AppShell();

        }
    }
}