using Api.Category.Infrastructure;
using Api.Category.Models;
using Microsoft.EntityFrameworkCore;
using Shared.Repository;

namespace Api.Category.Business;

public class CategoryRepository : GenericRepository<Models.Category>,ICategoryRepository
{
    public CategoryRepository(CategoryDbContext dbContext) : base(dbContext)
    {
    }
}
