using Xamarin.Forms;

namespace TaskList.Base
{
    public class ContentPageBase : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModelBase viewModel = BindingContext as ViewModelBase;
            viewModel?.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ViewModelBase viewModel = BindingContext as ViewModelBase;
            viewModel?.OnDisappearing();
        }
    }
}
