using FluentValidation;
using LinqLab.Domain.Entities;
using LinqLab.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLab.Application.Abstractions.Todos.Commands.CreateTodo
{
    public class CreateTodoCommandHandler : IRequestHandler<CreateTodoCommand, Guid>
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IValidator<CreateTodoCommand> _validator;

        public CreateTodoCommandHandler(ITodoRepository todoRepository, IValidator<CreateTodoCommand> validator)
        {
            _todoRepository = todoRepository;
            _validator = validator;
        }
        public async Task<Guid> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request,cancellationToken);

            if (validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var todo = new TodoItem(request.Title, request.Priority);

            await _todoRepository.AddAsync(todo,cancellationToken);

            return todo.Id;
        }
    }
}
