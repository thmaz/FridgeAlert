using FridgeAlert.Models;
using PropertyChanged;
using System.Windows.Input;

namespace FridgeAlert.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewModel
    {
        public List<User> Users { get; set; }
        public User? CurrentUser { get; set; }
        public ICommand? AddOrUpdateCommand { get; set; }


        public MainPageViewModel()
        {
            /*
            AddOrUpdateCommand = new Command(async =>
            {
                App.UserRepo.AddOrUpdate(CurrentUser);
            });
            */
        }
    }


}
