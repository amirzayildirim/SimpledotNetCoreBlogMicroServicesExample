using Api.Category.Infrastructure;
using AutoMapper;
using Shared.Models.CategoryModels;
using Shared.Repository;
using Shared.Service;

namespace Api.Category.Business;

public class CategoryService : GenericService<Models.Category>, ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper) : base(categoryRepository)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<bool> AddAsync(CategoryAddModel entity)
    {
        try
        {
            var mappedEntity = _mapper.Map<CategoryAddModel,Models.Category>(entity);
            await _categoryRepository.AddAsync(mappedEntity);

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
    }

    public async Task<bool> Update(CategoryUpdateModel entity)
    {
        try
        {
            var mappedEntity = _mapper.Map<Models.Category>(entity);
            await _categoryRepository.Update(mappedEntity);

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
    }

    public new async Task<IEnumerable<CategoryViewModel>?> GetAllAsync()
    {
        try
        {
           var list =  await _categoryRepository.GetAllAsync();

            var mappedEntity = _mapper.Map<IEnumerable<CategoryViewModel>>(list);

            return mappedEntity;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

            return null;
        }
    }

    public new async Task<CategoryViewModel> GetById(int id)
    {
        try
        {
          var result =   await _categoryRepository.GetById(id);
            var mappedEntity = _mapper.Map<CategoryViewModel>(result);

            return mappedEntity;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
    }

    public async new Task<bool> Delete(int id)
    {
        try
        {
            await _categoryRepository.Delete(id);

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
    }
}
