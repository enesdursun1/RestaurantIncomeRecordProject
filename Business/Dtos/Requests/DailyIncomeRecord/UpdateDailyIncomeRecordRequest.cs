namespace Business.Dtos.Requests.DailyIncomeRecord;

public class UpdateDailyIncomeRecordRequest
{
    public int Id { get; set; }
    public string ProductName { get; set; }

    public int Quantity { get; set; }
    public decimal Price { get; set; }



}

