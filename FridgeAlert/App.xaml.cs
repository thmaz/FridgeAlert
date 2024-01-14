using FridgeAlert.Models;
using FridgeAlert.Data;

namespace FridgeAlert
{
    public partial class App : Application
    {
        public static BaseRepository<Fridges>? FridgeRepo { get; private set; }
        public App(BaseRepository<Fridges> fridgeRepo)
        {
            InitializeComponent();

            FridgeRepo = fridgeRepo;
            MainPage = new AppShell();

        }
    }
}