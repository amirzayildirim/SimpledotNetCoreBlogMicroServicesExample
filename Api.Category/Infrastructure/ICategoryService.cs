using Shared.Models.CategoryModels;
using Shared.Service;

namespace Api.Category.Infrastructure;

public interface ICategoryService : IGenericService<Models.Category>
{
    new Task<IEnumerable<CategoryViewModel>?> GetAllAsync();
    new Task<CategoryViewModel> GetById(int id);
    Task<bool> AddAsync(CategoryAddModel entity);
    Task<bool> Update(CategoryUpdateModel entity);
    new Task<bool> Delete(int id);
}

