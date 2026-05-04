using API_Projects.Application.Todos.Dtos;

namespace API_Projects.Application.Todos.Validations
{
    public interface IValidateTodo
    {
        public ValidationResult Validate(TodoDto todo);
    }
}
