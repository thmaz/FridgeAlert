using FridgeAlert.ViewModel;

namespace FridgeAlert.Views;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
        BindingContext = new RegisterViewModel();
    }
}