using Microsoft.EntityFrameworkCore;

namespace Api.Category.Models;

public class CategoryDbContext : DbContext
{
    public CategoryDbContext(DbContextOptions<CategoryDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
}
