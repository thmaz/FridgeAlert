using System.Collections.ObjectModel;
using FridgeAlert.Models;

namespace FridgeAlert.ViewModel;
public class FridgeViewModel
{
    public ObservableCollection<FridgeModel> Entries { get; } = new ObservableCollection<FridgeModel>();
    
    public void AddFridge (FridgeModel entry)
    {
        Entries.Add (entry);
    }
}

