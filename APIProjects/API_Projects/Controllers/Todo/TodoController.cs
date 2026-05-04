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
        private readonly IValidateTodo _validateTodo;


        public TodoController(ITodoService todoService, IValidateTodo validateTodo)
        {
            _todoService = todoService;
            _validateTodo = validateTodo;
        }

        [HttpGet]
        public ActionResult GetTodos()
        {
           
            return Ok(_todoService.GetAll());
        }

        [HttpPost]
        public ActionResult CreateTodo([FromBody]  TodoDto dto)
        {
            var validation = _validateTodo.Validate(dto);

            if(validation.IsValid)
            {
                return BadRequest(new ApiResponse<object>
                {
                    Success = false,
                    Errors = validation.Errors
                }
                );
            }
            _todoService.AddTodo(dto);
           
            _todoService.AddTodo(dto);
            return CreatedAtAction(nameof(GetTodoById), new ApiResponse<TodoDto>
            {
                Success = true,
                Data = dto
            });

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
