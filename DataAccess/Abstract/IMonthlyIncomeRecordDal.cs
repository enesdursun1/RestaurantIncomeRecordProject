using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IMonthlyIncomeRecordDal : IAsyncRepository<MonthlyIncomeRecord, int>, IRepository<MonthlyIncomeRecord, int>
{

}
