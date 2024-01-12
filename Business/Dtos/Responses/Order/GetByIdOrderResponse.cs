namespace Business.Dtos.Responses.Order;

public class GetByIdOrderResponse
{
    public int Id { get; set; }

    public string TableName { get; set; }
    public string ProductName { get; set; }


    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
