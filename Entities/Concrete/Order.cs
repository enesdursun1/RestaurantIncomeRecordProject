using Core.Entities;

namespace Entities.Concrete;

public class Order : Entity<int>
{

    public int ProductId { get; set; }
    public int TableId { get; set; }

    public int Quantity { get; set; }
    public decimal Price { get; set; }



    public virtual Product Product { get; set; }
    public virtual Table Table { get; set; }
   






}
