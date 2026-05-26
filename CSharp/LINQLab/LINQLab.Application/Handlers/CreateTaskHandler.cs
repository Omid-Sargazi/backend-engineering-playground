using LinqLab.Domain.Entities;
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
    public class CreateTaskHandler : IRequestHandler<CreateTaskCommand, TaskDto>
    {
        private readonly ITaskRepository _repository;
        public CreateTaskHandler(ITaskRepository repository)
        {
            _repository = repository;
        }
        public async Task<TaskDto> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = new TodoItem(request.Title, request.Priority);
            await _repository.AddAsync(task, cancellationToken);
            return new TaskDto(task.Id, task.Title, task.IsCompleted,task.Priority.ToString());
        }
    }
}
