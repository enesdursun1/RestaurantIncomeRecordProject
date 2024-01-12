using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IOrderDal : IAsyncRepository<Order, int>, IRepository<Order, int>
{
  
}
