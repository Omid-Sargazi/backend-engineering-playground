namespace API_Projects.Application.Todos.Validations
{
    public enum ErrorCodes
    {
        TitleRequired =1001,
        TitleTooShort = 1002,
        DueDateInPast = 1003,
        TodoNotFound = 1004,
        TitleMinLength = 1005,
        Success = 2000,
    }

   
}
