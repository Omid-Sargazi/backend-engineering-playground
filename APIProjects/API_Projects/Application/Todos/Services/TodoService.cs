using API_Projects.Application.Todos.Dtos;
using API_Projects.Application.Todos.Validations;

namespace API_Projects.Application.Todos.Services
{
    public class TodoService : ITodoService
    {
        private  readonly static List<TodoDto> _todoList = [];
        private readonly IValidateTodo _validateTodo;

        public TodoService(IValidateTodo validateTodo)
        {
            _validateTodo = validateTodo;
        }
        public void AddTodo(TodoDto todoDto)
        {
            var result = _validateTodo.Validate(todoDto);
            if(result.IsValid)
                _todoList.Add(todoDto);

        }

        public void Delete(int id)
        {
            var res = FindById(id);
            _todoList.Remove(res);
        }

        public TodoDto FindById(int id)
        {
            var result = _todoList.FirstOrDefault(x=>x.Id==id);
            if(result ==null)
            {
                return null;
            }
            return result;
            
        }

        public List<TodoDto> GetAll()
        {
            return _todoList;
        }

        public void Update(int id,string title)
        {
            var result = FindById(id);
            result.Title = title;

        }
    }
}
