using Core.DataAccess.Repositories;
using DataAccess.Abstract;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class EfMonthlyIncomeRecordDal : EfRepositoryBase<MonthlyIncomeRecord, int, BaseDbContext>, IMonthlyIncomeRecordDal
{
    public EfMonthlyIncomeRecordDal(BaseDbContext context) : base(context)
    {
    }


}
