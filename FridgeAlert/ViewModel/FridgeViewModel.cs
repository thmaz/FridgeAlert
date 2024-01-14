
/* Unmerged change from project 'FridgeAlert (net7.0-windows10.0.19041.0)'
Before:
using System.Collections.ObjectModel;
using System.Windows.Input;
using FridgeAlert.Models;
After:
using FridgeAlert.Data;
using FridgeAlert.Models;
using PropertyChanged;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-ios)'
Before:
using System.Collections.ObjectModel;
using System.Windows.Input;
using FridgeAlert.Models;
After:
using FridgeAlert.Data;
using FridgeAlert.Models;
using PropertyChanged;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-maccatalyst)'
Before:
using System.Collections.ObjectModel;
using System.Windows.Input;
using FridgeAlert.Models;
After:
using FridgeAlert.Data;
using FridgeAlert.Models;
*/
using PropertyChanged;
using FridgeAlert.Models;
using System.Windows.Input;

namespace FridgeAlert.ViewModel
{

    [AddINotifyPropertyChangedInterface]
    public class FridgeViewModel
    {
        public ICommand? AddOrUpdateCommand { get; set; }
        public ICommand? DeleteCommand { get; set; }
        public List<Fridges> Fridges { get; set; }
        public Fridges? CurrentFridge { get; set; }

        public FridgeViewModel()
        {

            AddOrUpdateCommand = new Command(async () =>
            {
                App.FridgeRepo.AddOrUpdate(CurrentFridge);
                Console.WriteLine(App.FridgeRepo.StatusMessage);
                Refresh();
            });
        }

        private void Refresh()
        {
            Fridges = App.FridgeRepo.GetAll();
        }
    }
}

