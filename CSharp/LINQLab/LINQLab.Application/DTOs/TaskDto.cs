using LinqLab.Domain.Consts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLab.Application.DTOs
{
    public record TaskDto(Guid id, string title, bool isCompleted, string priority);
    

    public record CreateTaskCommand(string Title, Priority Priority):IRequest<TaskDto>;
    public record GetAllTaskQuery():IRequest<List<TaskDto>>;
}
