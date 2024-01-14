using FridgeAlert.Models;
using System.Windows.Input;

namespace FridgeAlert.ViewModel
{
    public class RegisterViewModel
    {
        public User CurrentUser { get; set; }
        public ICommand AddOrUpdateCommand { get; set; }

        public RegisterViewModel()
        {
            CurrentUser = new User();
            AddOrUpdateCommand = new Command(OnAddOrUpdate);
        }

        private void OnAddOrUpdate()
        {
            App.UserRepo.AddOrUpdate(CurrentUser);
        }
    }
}
