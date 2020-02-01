namespace TaskList
{
    using TaskList.Services;
    using Xamarin.Forms;

    public partial class App : Application
    {
        private readonly INavigationService navigationService;
        
        public App()
        {
            navigationService = DependencyService.Resolve<INavigationService>();
            InitializeComponent();

            navigationService.InitApp();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
