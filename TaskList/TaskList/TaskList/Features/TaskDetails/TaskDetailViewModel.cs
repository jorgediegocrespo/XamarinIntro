namespace TaskList.Features
{
    using System.Windows.Input;
    using TaskList.Base;
    using TaskList.Model;
    using TaskList.Services;
    using Xamarin.Forms;

    public class TaskDetailViewModel : ViewModelBase
    {
        private readonly ITaskApi taskApiService;
        private readonly INavigationService navigationService;

        private int currentTaskId;
        private string title;
        private string description;

        public TaskDetailViewModel(int taskId)
        {
            taskApiService = DependencyService.Resolve<ITaskApi>();
            navigationService = DependencyService.Resolve<INavigationService>();

            currentTaskId = taskId;
            title = string.Empty;
            description = string.Empty;

            CreateCommands();
        }

        public string Title
        {
            get => title;
            set
            {
                title = value;
                RaisePropertyChanged();
            }
        }

        public string Description
        {
            get => description;
            set
            {
                description = value;
                RaisePropertyChanged();
            }
        }

        public ICommand SaveTaskCommand { get; set; }
        public ICommand RemoveTaskCommand { get; set; }

        public void CreateCommands()
        {
            SaveTaskCommand = new Command(SaveAsync);
            RemoveTaskCommand = new Command(RemoveAsync);
        }

        public override async void OnAppearing()
        {
            base.OnAppearing();
            TaskItem taskItem = null;
            if (currentTaskId > 0)
                taskItem = await taskApiService.GetTaskAsync(currentTaskId);

            Title = taskItem?.Title;
            Description = taskItem?.Description;
        }

        private async void SaveAsync(object obj)
        {
            TaskItem taskItem = new TaskItem()
            {
                Id = currentTaskId,
                Title = this.Title,
                Description = this.Description
            };

            await taskApiService.SaveTaskAsync(taskItem);
            await navigationService.NavigateBack();
        }

        private async void RemoveAsync(object obj)
        {
            await taskApiService.RemoveTaskAsync(currentTaskId);
            await navigationService.NavigateBack();
        }
    }
}
