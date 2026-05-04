namespace API_Projects.Application.Todos.Dtos
{
    public class TodoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime? DueTime { get; set; }
    }
}
