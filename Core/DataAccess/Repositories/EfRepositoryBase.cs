﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Core.DataAccess.Repositories;

public class EfRepositoryBase<TEntity, TEntityId,TContext> : IAsyncRepository<TEntity, TEntityId>,IRepository<TEntity, TEntityId>
    where TEntity : Entity<TEntityId>
    where TContext : DbContext
{
    public TContext Context { get; set; }

    public EfRepositoryBase(TContext context)
    {
        Context = context;
    }

    public IQueryable<TEntity> Query() => Context.Set<TEntity>();



    public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate ,Func<IQueryable<TEntity>,
        IIncludableQueryable<TEntity, object>>? include = null, bool enableTracking = true,
         CancellationToken cancellationToken = default)
    {
        IQueryable<TEntity> queryable = Query();
        if (!enableTracking) queryable = queryable.AsNoTracking();
        if (include != null)      
        queryable = include(queryable);
        return await queryable.FirstOrDefaultAsync(predicate, cancellationToken);
    }

   

    public async Task<IList<TEntity?>> GetListAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool enableTracking = true, CancellationToken cancellationToken = default)
    {
        IQueryable<TEntity> queryable = Query();
        if (!enableTracking) queryable = queryable.AsNoTracking();
        if (include != null)
            queryable = include(queryable);
        if (predicate != null)
            queryable = queryable.Where(predicate);
        if (orderBy != null) 
            return await orderBy(queryable).ToListAsync(cancellationToken);
            return await queryable.ToListAsync(cancellationToken);
    }
    public async Task<TEntity> AddAsync(TEntity entity)
    {
       await Context.AddAsync(entity);
       await Context.SaveChangesAsync();
       Context.Entry(entity).State = EntityState.Detached;
        return entity;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
       Context.Update(entity);
        await Context.SaveChangesAsync();
        Context.Entry(entity).State = EntityState.Detached;
        return entity;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity)
    {
        Context.Remove(entity);
        await Context.SaveChangesAsync();
        return entity;
    }

    public async Task<IList<TEntity>> DeleteRangeAsync(IList<TEntity> entities)
    {
        Context.RemoveRange(entities);
        await Context.SaveChangesAsync();
        return entities;
    }



    public IList<TEntity> GetList(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
    {
        IQueryable<TEntity> queryable = Query();
        if (include != null)
            queryable = include(queryable);
        if (predicate != null)
            queryable.Where(predicate);
        if (orderBy != null)
            return orderBy(queryable).ToList();
        return queryable.ToList();
    }


    public TEntity Update(TEntity entity)
    {
        Context.Update(entity);
        Context.SaveChanges();
        return entity;
    }

   
    public TEntity Add(TEntity entity)
    {
        Context.Add(entity);
        Context.SaveChanges();
        return entity;
    }

  
    public TEntity Delete(TEntity entity)
    {
        Context.Remove(entity);
        Context.SaveChanges();
        return entity;
    }

   

    public TEntity Get(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>
        , IIncludableQueryable<TEntity, object>>? include = null) { 
    
        IQueryable<TEntity> queryable = Query();
        if (include != null)
            queryable = include(queryable);
        return queryable.FirstOrDefault(predicate);
    }
}
