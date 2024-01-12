namespace Business.Dtos.Requests.Product;

public class UpdateProductRequest
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
  
}
