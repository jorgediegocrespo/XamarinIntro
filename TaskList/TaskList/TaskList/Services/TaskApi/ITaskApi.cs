namespace TaskList.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TaskList.Model;

    public interface ITaskApi
    {
        Task<IEnumerable<TaskItem>> GetTaskListAsync();
        Task<TaskItem> GetTaskAsync(int id);
        Task SaveTaskAsync(TaskItem taskItem);
        Task RemoveTaskAsync(int id);
    }
}
