using LinqLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Domain.Repositories
{
    public interface ITaskRepository
    {
        Task AddAsync(TodoItem task,CancellationToken cancellationToken);
        Task<List<TodoItem>> GetAllAsync(CancellationToken cancellationToken);
    }
}
