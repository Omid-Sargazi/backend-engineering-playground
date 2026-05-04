using API_Projects.Application.Todos.Dtos;
using API_Projects.Application.Todos.Services;
using API_Projects.Application.Todos.Validations;
using Microsoft.AspNetCore.Mvc;

namespace API_Projects.Controllers.Todo
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController:ControllerBase
    {
        
        private readonly ITodoService _todoService;


        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public ActionResult GetTodos()
        {
           
            return Ok(_todoService.GetAll());
        }

        [HttpPost]
        public ActionResult CreateTodo([FromBody]  TodoDto dto)
        {
           
            _todoService.AddTodo(dto);
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<TodoDto> GetTodoById(int id)
        {
           
            return Ok(_todoService.FindById(id));
        }

        [HttpPut]
        public ActionResult<TodoDto> UpdateTodo(int id, string newTitle)
        {
            _todoService.Update(id, newTitle);
            return Ok(GetTodoById(id));
        }
    }
}
