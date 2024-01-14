/* Unmerged change from project 'FridgeAlert (net7.0-windows10.0.19041.0)'
Before:
using FridgeAlert.Models;
After:
using FridgeAlert.ViewModel;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-ios)'
Before:
using FridgeAlert.Models;
After:
using FridgeAlert.ViewModel;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-maccatalyst)'
Before:
using FridgeAlert.Models;
After:
using FridgeAlert.ViewModel;
*/
namespace FridgeAlert.Views;

public partial class AddFridge : ContentPage
{
    public FridgeViewModel _viewModel;
    public AddFridge(FridgeViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    private void AddFridgeButton_Clicked(object sender, EventArgs e)
    {
        var newFridge = new FridgeModel
        {
            Name = EntryName.Text
        };

        _viewModel.AddFridge(newFridge);
        Navigation.PopAsync();
    }
}