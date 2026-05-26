using LinqLab.Domain.Consts;
using LinqLab.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLab.Application.Abstractions.Todos.Queries
{
    public class GetTodoByIdQuery:IRequest<TodoDto>
    {
        public Guid Id { get; set; }
    }

    public class TodoDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public Priority Priority { get; set; }


        public static TodoDto FromEntity(TodoItem item)
        {
            return new TodoDto
            {
                Id = item.Id,
                Title = item.Title,
                IsCompleted = item.IsCompleted,
                Priority = item.Priority,
            };
        }
    }
}
