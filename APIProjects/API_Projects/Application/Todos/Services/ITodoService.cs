using API_Projects.Application.Todos.Dtos;

namespace API_Projects.Application.Todos.Services
{
    public interface ITodoService
    {
        public void AddTodo(TodoDto todoDto);
        public TodoDto FindById(int id);
        public void Update(int id, string title);
        public void Delete(int id);
        public List<TodoDto> GetAll();

    }
}
