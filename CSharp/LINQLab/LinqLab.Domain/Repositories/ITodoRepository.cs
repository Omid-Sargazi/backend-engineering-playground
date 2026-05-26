using LinqLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Domain.Repositories
{
    public interface ITodoRepository
    {
        Task AddAsync(TodoItem todo,CancellationToken cancellationToken);
        Task<TodoItem> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task UpdateAsync(TodoItem todo,CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
        Task<List<TodoItem>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
