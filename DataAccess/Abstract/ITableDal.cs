using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface ITableDal : IAsyncRepository<Table, int>, IRepository<Table, int>
{
}
