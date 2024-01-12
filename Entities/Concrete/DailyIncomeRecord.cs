using Core.Entities;

namespace Entities.Concrete;

public class DailyIncomeRecord : Entity<int>
{
    public string ProductName { get; set; }

    public int Quantity { get; set; }
    public decimal Price { get; set; }




 
}
