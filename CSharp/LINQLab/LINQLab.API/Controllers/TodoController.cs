using LINQLab.Application.Abstractions.Todos.Commands.CreateTodo;
using LINQLab.Application.Abstractions.Todos.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LINQLab.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TodoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateTodo(CreateTodoCommand command)
        {
            var id = await _mediator.Send(command); 
            return Ok(id);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoDto>> GetTodoById(Guid id)
        {
            var query = new GetTodoByIdQuery { Id = id };
            var todo = await _mediator.Send(query); 
            return Ok(todo);    
        }

    }
}
