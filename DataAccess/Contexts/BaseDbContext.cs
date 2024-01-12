using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts;

public class BaseDbContext:DbContext
{
    public DbSet<Product>Products  { get; set; }
    public DbSet<Category> Categories  { get; set; }
    public DbSet<Table> Tables  { get; set; }
    public DbSet<Order> Orders  { get; set; }
    public DbSet<MonthlyIncomeRecord> MonthlyIncomeRecords { get; set; }
    public DbSet<DailyIncomeRecord> DailyIncomeRecords { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["RestaurantProjectConnectionString"].ConnectionString);
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }

}
