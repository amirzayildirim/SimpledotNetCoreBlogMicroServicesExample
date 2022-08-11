using Api.Comment.Models.Entities;
using Shared.Repository;

namespace Api.Comment.Infrastructure;

public interface ICommentRepository: IGenericRepository<CommentEntity>
{
}
