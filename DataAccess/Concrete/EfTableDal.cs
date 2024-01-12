using Core.DataAccess.Repositories;
using DataAccess.Abstract;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class EfTableDal : EfRepositoryBase<Table, int, BaseDbContext>, ITableDal
{
    public EfTableDal(BaseDbContext context) : base(context)
    {
    }
}
