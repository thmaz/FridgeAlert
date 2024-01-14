using FridgeAlert.ViewModel;
namespace FridgeAlert.Views;

public partial class FridgeList : ContentPage
{
    private FridgeViewModel _viewModel;
    public FridgeList()
    {
        InitializeComponent();
        _viewModel = new FridgeViewModel();
        BindingContext = _viewModel;
    }
    private async void AddFridge_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddFridge(_viewModel));
    }
}