using Shared.Models;
using Shared.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Service;

public class GenericService<Tentity> : IGenericService<Tentity> where Tentity : BaseEntities
{
    private  readonly IGenericRepository<Tentity> _repo;

    public GenericService(IGenericRepository<Tentity> repo)
    {
        _repo = repo;
    }

    public virtual  async Task AddAsync(Tentity entity)
    {
        await _repo.AddAsync(entity);
    }

    public virtual async Task Delete(int id)
    {
        await _repo.Delete(id);
    }

    public virtual Task<IEnumerable<Tentity>> GetAllAsync()
    {
        return _repo.GetAllAsync();
    }

    public virtual async Task<Tentity> GetById(int id)
    {
      return  await _repo.GetById(id);
    }

    public virtual async Task Update(Tentity entity)
    {
         await _repo.Update(entity);
    }
}
