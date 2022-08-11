using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Service
{
    public  interface IGenericService<TEntity> where TEntity : BaseEntities
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetById(int id);
        Task AddAsync(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(int id);
    }
}
