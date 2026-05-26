using LinqLab.Domain.Entities;
using LinqLab.Domain.Repositories;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLab.Infrastructure.Persistence.InMemory
{
    public class TodoRepository : ITodoRepository
    {
        private readonly ConcurrentDictionary<Guid, TodoItem> _todos = new();

        public Task AddAsync(TodoItem todo, CancellationToken cancellationToken)
        {
            _todos.TryAdd(todo.Id, todo);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            _todos.TryRemove(id, out _);
            return Task.CompletedTask;
        }

        public Task<List<TodoItem>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var todos = _todos.Values.ToList();
            return Task.FromResult(todos);
        }

        public Task<TodoItem> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            _todos.TryGetValue(id, out var todo);
            return Task.FromResult(todo);
        }

        public Task UpdateAsync(TodoItem todo, CancellationToken cancellationToken)
        {
            _todos.TryUpdate(todo.Id,todo,todo);
            return Task.CompletedTask;
        }
    }
}
