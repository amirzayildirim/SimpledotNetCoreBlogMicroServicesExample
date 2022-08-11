using Api.Comment.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Comment.Models;

public class CommentDbContext : DbContext
{
    public CommentDbContext(DbContextOptions options) : base(options)
    {
    }

    DbSet<CommentEntity> Comments { get; set; }
}
