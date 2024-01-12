using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public static class DataAccessServiceRegistration
{

    public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
    {
        services.AddDbContext<BaseDbContext>();
   

        services.AddScoped<IProductDal, EfProductDal>();
        services.AddScoped<ICategoryDal, EfCategoryDal>();
        services.AddScoped<ITableDal, EfTableDal>();
        services.AddScoped<IOrderDal, EfOrderDal>();
        services.AddScoped<IMonthlyIncomeRecordDal, EfMonthlyIncomeRecordDal>();
        services.AddScoped<IDailyIncomeRecordDal, EfDailyIncomeRecordDal>();
       
      


        return services;
    }
}
