[assembly: Xamarin.Forms.Dependency(typeof(TaskList.Services.NavigationService))]
namespace TaskList.Services
{
    using System.Threading.Tasks;
    using TaskList.Features;
    using Xamarin.Forms;

    public class NavigationService : INavigationService
    {
        private INavigation FormsNavigation
        {
            get
            {
                if (Application.Current.MainPage is NavigationPage navigationPage)
                {
                    return navigationPage.Navigation;
                }

                if (Application.Current.MainPage is TabbedPage tabbedPage)
                {
                    return tabbedPage.CurrentPage.Navigation;
                }

                return Application.Current.MainPage.Navigation;
            }
        }

        public void InitApp()
        {
            Application.Current.MainPage = new NavigationPage(new TaskListView() { BindingContext = new TaskListViewModel() });
        }

        public async Task NavigateToTaskDetailAsync(int itemId)
        {
            TaskDetailView view = new TaskDetailView { BindingContext = new TaskDetailViewModel(itemId) };
            await FormsNavigation.PushAsync(view);
        }

        public async Task NavigateBack()
        {
            await FormsNavigation.PopAsync();
        }
    }
}
