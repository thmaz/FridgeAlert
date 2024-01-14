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
        public List<int> AmountOptions { get; set; }
        public int SelectedAmount { get; set; }
        public DateTime SelectedPurchaseDate { get; set; }
        public bool IsDrink { get; set; }

        public FridgeViewModel()
        {
            AmountOptions = new List<int> { 1, 2, 3, 4, 5 };

            // Set default values
            SelectedAmount = AmountOptions[0]; // Set to the first option
            SelectedPurchaseDate = DateTime.Now; // Set to the current date
            IsDrink = false; // Default value

            AddOrUpdateCommand = new Command(async () =>
            {
                CurrentFridge.Amount = SelectedAmount;
                CurrentFridge.PurchaseDate = SelectedPurchaseDate.ToString("yyyy-MM-dd");
                CurrentFridge.isDrink = IsDrink;

                App.FridgeRepo.SaveEntityWithChildren(CurrentFridge);
                Console.WriteLine(App.FridgeRepo.StatusMessage);
                Refresh();
            });

            DeleteCommand = new Command(async () =>
            {
                App.FridgeRepo.DeleteEntitiesWithChildren(CurrentFridge);
                Console.WriteLine(App.FridgeRepo.StatusMessage);
                Refresh();
            });
        }

        private void Refresh()
        {
            Fridges = App.FridgeRepo.GetEntitiesWithChildren();
        }
    }
}

