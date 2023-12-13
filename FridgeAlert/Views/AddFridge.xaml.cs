using FridgeAlert.ViewModel;
using FridgeAlert.Models;
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