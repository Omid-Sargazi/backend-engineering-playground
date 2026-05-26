using LINQLab.Application.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LINQLab.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ISender _mediator;
        public TasksController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<TaskDto>> Create(CreateTaskCommand cmd) =>
        Ok(await _mediator.Send(cmd));


        [HttpGet]
        public async Task<ActionResult<List<TaskDto>>> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllTaskQuery()));
        }
    }
}
