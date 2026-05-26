using LinqLab.Domain.Entities;
using LinqLab.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLab.Application.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private static readonly List<TodoItem> _tasks = new List<TodoItem>(); 
        public Task AddAsync(TodoItem task, CancellationToken cancellationToken)
        {
            _tasks.Add(task);
            return Task.CompletedTask;
        }

        public async Task<List<TodoItem>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await Task.FromResult(_tasks.ToList());
        }
    }
}
