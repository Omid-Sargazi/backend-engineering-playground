using LinqLab.Domain.Repositories;
using LINQLab.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLab.Application.Handlers
{
    public class GetAllTasksHandler : IRequestHandler<GetAllTaskQuery, List<TaskDto>>
    {
        private readonly ITaskRepository _repository;
        public GetAllTasksHandler(ITaskRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<TaskDto>> Handle(GetAllTaskQuery request, CancellationToken cancellationToken)
        {
            var tasks = await _repository.GetAllAsync(cancellationToken);

            var result = tasks.Select(task => new TaskDto(
            task.Id,
            task.Title,
            task.IsCompleted,
            task.Priority.ToString()
        )).ToList();

            return result;
        }
    }
}
