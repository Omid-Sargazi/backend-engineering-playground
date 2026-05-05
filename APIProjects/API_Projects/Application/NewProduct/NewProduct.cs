namespace API_Projects.Application.NewProduct
{
    public class NewProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } = false;
    }
}
