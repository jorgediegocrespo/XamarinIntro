namespace TaskList.Features
{
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using TaskList.Base;
    using TaskList.Model;
    using TaskList.Services;
    using Xamarin.Forms;
    using Xamarin.Forms.Internals;

    public class TaskListViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;
        private readonly ITaskApi taskApiService;

        private ObservableCollection<TaskItem> items;
        private TaskItem selectedItem;

        public TaskListViewModel()
        {
            navigationService = DependencyService.Resolve<INavigationService>();
            taskApiService = DependencyService.Resolve<ITaskApi>();

            items = new ObservableCollection<TaskItem>();
            selectedItem = null;

            CreateCommands();
        }

        public ObservableCollection<TaskItem> Items
        {
            get => items;
            set
            {
                items = value;
                RaisePropertyChanged();
            }
        }

        public TaskItem SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                RaisePropertyChanged();

                if (selectedItem != null)
                    navigationService.NavigateToTaskDetailAsync(selectedItem.Id);
            }
        }

        public ICommand AddTaskCommand { get; set; }

        private void CreateCommands()
        {
            AddTaskCommand = new Command(async () => await navigationService.NavigateToTaskDetailAsync(0));
        }

        public override async void OnAppearing()
        {
            base.OnAppearing();
            var apiItems = (await taskApiService.GetTaskListAsync());
            Items.Clear();
            apiItems.ForEach(o => Items.Add(o));
        }
    }
}
