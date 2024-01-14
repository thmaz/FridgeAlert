using FridgeAlert.ViewModel;
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
}