namespace API_Projects.Application.Todos.Validations
{
    public class ValidationResult
    {
        public bool IsValid =>!Errors.Any();
        public List<ErrorMessgae> Errors { get; set; }
    }
}
