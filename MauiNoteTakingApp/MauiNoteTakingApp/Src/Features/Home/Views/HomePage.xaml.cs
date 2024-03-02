using MauiNoteTakingApp.Src.Features.Home.ViewModels;

namespace MauiNoteTakingApp
{
    public partial class HomePage : ContentPage
    {
        private readonly HomeViewModel _viewModel;

        public HomePage()
        {
            InitializeComponent();

            _viewModel = new();
            BindingContext = _viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.LoadNotes();
        }
    }
}
