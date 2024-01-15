using FridgeAlert.ViewModel;
using FridgeAlert.Models;

namespace FridgeAlert.Views
{

    public partial class AddFridge : ContentPage
    {
        public FridgeViewModel _viewModel;
        public AddFridge(FridgeViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            _viewModel.CurrentFridge = new Fridges();
            BindingContext = _viewModel;
        }
    }
}