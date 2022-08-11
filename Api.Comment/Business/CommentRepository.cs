using Api.Comment.Infrastructure;
using Api.Comment.Models;
using Api.Comment.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Shared.Repository;

namespace Api.Comment.Business;

public class CommentRepository : GenericRepository<CommentEntity>, ICommentRepository
{
    public CommentRepository(CommentDbContext dbContext) : base(dbContext)
    {
    }
}
