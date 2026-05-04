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
        private static readonly List<TodoDto> _todoDtos = [];
        private readonly IValidateTodo _validateTodo;
        private readonly ITodoService _todoService;
       

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public ActionResult GetTodos()
        {
            //if(_todoDtos.Any())
            //    return Ok(_todoDtos);
            //return NotFound("There isn`t any todos for today.");
            return Ok(_todoService.GetAll());
        }

        [HttpPost]
        public ActionResult CreateTodo([FromBody]  TodoDto dto)
        {
            //if (_validateTodo.Validate(dto)){
            //    _todoDtos.Add(dto);
            //}
           
            //else
            //{
            //    return BadRequest("TItle Cannot be Empty");
            //}
            //return Ok(dto);

            _todoService.AddTodo(dto);
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<TodoDto> GetTodoById(int id)
        {
            //var result = _todoDtos.FirstOrDefault(x => x.Id == id);
            //if(result ==null)
            //{
            //    return NotFound($"there is not any todo by id:{id}");
            //}

            //return Ok(result);

            return Ok(_todoService.FindById(id));
        }
    }
}
