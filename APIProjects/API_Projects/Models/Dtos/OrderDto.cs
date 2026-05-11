namespace API_Projects.Models.Dtos
{
    public class OrderDto
    {
        public string CustomerName { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public List<OrderItemDto> Items { get; set; }
    }
}
