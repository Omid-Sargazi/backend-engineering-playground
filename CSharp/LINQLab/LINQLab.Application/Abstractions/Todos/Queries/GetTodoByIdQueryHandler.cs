using LinqLab.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLab.Application.Abstractions.Todos.Queries
{
    public class GetTodoByIdQueryHandler : IRequestHandler<GetTodoByIdQuery, TodoDto>
    {
        private readonly ITodoRepository _repository;
        public GetTodoByIdQueryHandler(ITodoRepository repository)
        {
            _repository = repository;
        }
        public async Task<TodoDto> Handle(GetTodoByIdQuery request, CancellationToken cancellationToken)
        {
            var todo = await _repository.GetByIdAsync(request.Id, cancellationToken);

            if(todo == null)
            {
                throw new Exception($"{request.Id}");
            }

            return TodoDto.FromEntity(todo);
        }
    }
}
