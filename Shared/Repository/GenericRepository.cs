using Microsoft.EntityFrameworkCore;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Repository;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntities
{
    private readonly DbContext _dbContext;

    public GenericRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(TEntity entity)
    {
        await _dbContext.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var entity = await GetById(id);
        _dbContext.Set<TEntity>().Remove(entity);

        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbContext.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity> GetById(int id)
    {
        return await _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task Update(TEntity entity)

    {
        var currentEntity = await GetById(entity.Id);
        entity.CreatedOn = currentEntity.CreatedOn;

        _dbContext.Set<TEntity>().Update(entity);
        await _dbContext.SaveChangesAsync();
    }
}
