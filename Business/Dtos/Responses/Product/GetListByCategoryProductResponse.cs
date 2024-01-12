using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Product;

public class GetListByCategoryProductResponse
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }


}
