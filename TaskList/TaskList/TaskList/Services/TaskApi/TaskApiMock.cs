﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskList.Model;

[assembly: Xamarin.Forms.Dependency(typeof(TaskList.Services.TaskApiMock))]
namespace TaskList.Services
{
    public class TaskApiMock : ITaskApi
    {
        private static List<TaskItem> taskItems;

        public TaskApiMock()
        {
            taskItems = taskItems ?? new List<TaskItem>()
            {
                new TaskItem() { Id = 1, Title = "Tarea 1", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 2, Title = "Tarea 2", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 3, Title = "Tarea 3", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 4, Title = "Tarea 4", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 5, Title = "Tarea 5", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 6, Title = "Tarea 6", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 7, Title = "Tarea 7", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 8, Title = "Tarea 8", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 9, Title = "Tarea 9", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 10, Title = "Tarea 10", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 11, Title = "Tarea 11", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 12, Title = "Tarea 12", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 13, Title = "Tarea 13", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 14, Title = "Tarea 14", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 15, Title = "Tarea 15", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 16, Title = "Tarea 16", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 17, Title = "Tarea 17", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 18, Title = "Tarea 18", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 19, Title = "Tarea 19", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 20, Title = "Tarea 20", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 21, Title = "Tarea 21", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 22, Title = "Tarea 22", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 23, Title = "Tarea 23", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 24, Title = "Tarea 24", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 25, Title = "Tarea 25", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 26, Title = "Tarea 26", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 27, Title = "Tarea 27", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 28, Title = "Tarea 28", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 29, Title = "Tarea 29", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." },
                new TaskItem() { Id = 30, Title = "Tarea 30", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur suscipit velit vitae justo maximus sollicitudin. Mauris nec urna in massa tristique lobortis. Sed ultricies, mi vitae tincidunt sodales, quam orci aliquet elit, vitae volutpat massa libero nec risus. Duis maximus faucibus tortor non fermentum. Suspendisse nec convallis ex, quis pharetra ipsum. Cras vestibulum est magna. Donec turpis dolor, aliquet in justo at, efficitur consequat mi. Etiam leo lacus, varius a ligula quis, tincidunt consequat nibh. Cras quis ultrices velit, sit amet vehicula lectus. Vivamus accumsan orci ex, eget scelerisque sapien sodales quis." }
            };
        }

        public Task<TaskItem> GetTaskAsync(int id)
        {
            TaskItem taskItem = taskItems.FirstOrDefault(ti => ti.Id == id);
            string serializedTaskItem = JsonConvert.SerializeObject(taskItem);
            TaskItem result = JsonConvert.DeserializeObject<TaskItem>(serializedTaskItem);

            return Task.FromResult(taskItem);
        }

        public Task<IEnumerable<TaskItem>> GetTaskListAsync()
        {
            string serializedTaskItems = JsonConvert.SerializeObject(taskItems);
            IEnumerable<TaskItem> result = JsonConvert.DeserializeObject<IEnumerable<TaskItem>>(serializedTaskItems);

            return Task.FromResult(result.ToList().OrderBy(t => t.Id).ToList() as IEnumerable<TaskItem>);
        }

        public Task RemoveTaskAsync(int id)
        {
            taskItems.RemoveAll(t => t.Id == id);
            return Task.CompletedTask;
        }

        public Task SaveTaskAsync(TaskItem taskItem)
        {
            if (taskItem.Id == 0)
                taskItem.Id = taskItems.Select(t => t.Id).Max() + 1;

            taskItems.RemoveAll(t => t.Id == taskItem.Id);
            taskItems.Add(taskItem);
            return Task.CompletedTask;
        }
    }
}
