using LinqLab.Domain.Consts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLab.Application.Abstractions.Todos.Commands.CreateTodo
{
    public class CreateTodoCommand:IRequest<Guid>
    {
        public string Title { get; set; }
        public Priority Priority { get; set; }
    }
}
