namespace TaskList.Services
{
    using System.Threading.Tasks;
    using TaskList.Model;

    public interface INavigationService
    {
        void InitApp();
        Task NavigateToTaskDetailAsync(int itemId);
        Task NavigateBack();
    }
}
