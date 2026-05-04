using API_Projects.Application.Todos.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API_Projects.Controllers.Todo
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController:ControllerBase
    {
        private static readonly List<TodoDto> _todoDtos = [];

        [HttpGet]
        public ActionResult<List<TodoDto>> GetTodos()
        {
            if(_todoDtos.Any())
                return Ok(_todoDtos);
            return NotFound("There isn`t any todos for today.");
        }

        [HttpPost]
        public ActionResult CreateTodo([FromBody]  TodoDto dto)
        {
            _todoDtos.Add(dto);
            return Ok(dto);
        }

        [HttpGet("{id}")]
        public ActionResult<TodoDto> GetTodoById(int id)
        {
            var result = _todoDtos.FirstOrDefault(x => x.Id == id);
            if(result ==null)
            {
                return NotFound($"there is not any todo by id:{id}");
            }

            return Ok(result);
        }
    }
}
