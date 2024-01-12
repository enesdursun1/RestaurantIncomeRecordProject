using Core.DataAccess.Repositories;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace DataAccess.Concrete;

public class EfOrderDal : EfRepositoryBase<Order, int, BaseDbContext>, IOrderDal
{
    public EfOrderDal(BaseDbContext context) : base(context)
    {
    }

 
}
