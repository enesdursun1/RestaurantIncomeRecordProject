using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IDailyIncomeRecordDal : IAsyncRepository<DailyIncomeRecord, int>, IRepository<DailyIncomeRecord, int>
{

}
