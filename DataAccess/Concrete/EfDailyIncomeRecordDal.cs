using Core.DataAccess.Repositories;
using DataAccess.Abstract;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class EfDailyIncomeRecordDal : EfRepositoryBase<DailyIncomeRecord, int, BaseDbContext>, IDailyIncomeRecordDal
{
    public EfDailyIncomeRecordDal(BaseDbContext context) : base(context)
    {
    }


}
