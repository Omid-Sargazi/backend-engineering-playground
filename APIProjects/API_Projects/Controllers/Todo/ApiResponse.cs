using API_Projects.Application.Todos.Validations;

namespace API_Projects.Controllers.Todo
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public List<ErrorMessgae> Errors { get; set; }
    }
}
