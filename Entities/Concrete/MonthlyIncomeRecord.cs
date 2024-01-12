using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class MonthlyIncomeRecord:Entity<int>
{
    public DateTime Date { get; set; }
    public decimal Price { get; set; }

 
}
