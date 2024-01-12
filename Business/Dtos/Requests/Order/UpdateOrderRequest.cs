namespace Business.Dtos.Requests.Order;

public class UpdateOrderRequest
{
    public int Id { get; set; }

    public int TableId { get; set; }
    public int ProductId { get; set; }

    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

