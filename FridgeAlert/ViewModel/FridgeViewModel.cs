using System.Collections.ObjectModel;
using FridgeAlert.Models;

namespace FridgeAlert.ViewModel;
public class FridgeViewModel
{
    public ObservableCollection<FridgeModel> FridgeModels { get; } = new ObservableCollection<FridgeModel>();
    
    public void AddFridge (FridgeModel entry)
    {
        FridgeModels.Add (entry);
    }

}

