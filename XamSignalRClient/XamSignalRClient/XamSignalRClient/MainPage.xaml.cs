using Xamarin.Forms;

namespace XamSignalRClient
{
    public partial class MainPage : ContentPage
    {
        ChatViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new ChatViewModel();
            this.BindingContext = viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.Connect();
        }

        protected override async void OnDisappearing()
        {
            base.OnDisappearing();
            await viewModel.Disconnect();
        }
    }
}