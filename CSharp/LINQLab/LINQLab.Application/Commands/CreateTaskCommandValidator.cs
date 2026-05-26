using FluentValidation;
using LINQLab.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLab.Application.Commands
{
    internal class CreateTaskCommandValidator:AbstractValidator<CreateTaskCommand>
    {
        public CreateTaskCommandValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title cannot be empty.")
                .MaximumLength(100).WithMessage("Title can be maximum 100 character.");

            RuleFor(x => x.Priority)
                .IsInEnum().WithMessage("Priority is invalid.");
        }
    }
}
