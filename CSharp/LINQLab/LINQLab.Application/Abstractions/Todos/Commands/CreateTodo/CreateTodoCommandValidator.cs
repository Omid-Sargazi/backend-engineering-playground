using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLab.Application.Abstractions.Todos.Commands.CreateTodo
{
    public class CreateTodoCommandValidator:AbstractValidator<CreateTodoCommand>
    {

        public CreateTodoCommandValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(100).WithMessage("Title must not exceed 100 characters.")
                .MinimumLength(1).WithMessage("Title must be at least 1 character.");

            RuleFor(x => x.Priority)
                .IsInEnum().WithMessage("Priority is invalid.");
        }
    }
}
