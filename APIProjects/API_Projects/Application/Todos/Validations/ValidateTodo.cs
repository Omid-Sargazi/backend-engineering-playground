using API_Projects.Application.Todos.Dtos;

namespace API_Projects.Application.Todos.Validations
{
    public class ValidateTodo : IValidateTodo
    {
        public ValidationResult Validate(TodoDto todo)
        {
            var result = new ValidationResult();
            return result;

        }

        private void ValidateTitle(TodoDto todo, ValidationResult result)
        {
            if(string.IsNullOrWhiteSpace(todo.Title))
            {
                result.Errors.Add(new ErrorMessgae
                {
                    ErrorCode = (int)ErrorCodes.TitleRequired,
                    Message = "Title is required",
                    Field = "title",
                });
                return;
            }

            if(todo.Title.Length<3)
            {
                result.Errors.Add(new ErrorMessgae
                {
                    ErrorCode = (int)ErrorCodes.TitleMinLength,
                    Message = "Title must be at least 3 character long",
                    Field = "title",
                });
            }
        }

        private void ValidateDueDate(TodoDto todo, ValidationResult result)
        {
            if(todo.DueTime.HasValue && todo.DueTime.Value.Date<DateTime.Today)
            {
                result.Errors.Add(new ErrorMessgae
                {
                    ErrorCode = (int)ErrorCodes.DueDateInPast,
                    Message = "DueDate Cannot be in the past",
                    Field = "DueDate"
                });
            }
        }
    }
}
