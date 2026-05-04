using API_Projects.Application.Todos.Dtos;

namespace API_Projects.Application.Todos.Validations
{
    public class ValidateTodo:IValidateTodo
    {
        public bool Validate(TodoDto todos)
        {
            if(todos.Title == null && todos.DueTime == null)
            {
                return false;
            }
            return true;
        }
    }
}
