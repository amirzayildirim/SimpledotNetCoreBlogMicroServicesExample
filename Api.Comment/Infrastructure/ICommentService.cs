using Api.Comment.Models.Entities;
using Shared.Models.CommentModels;
using Shared.Service;

namespace Api.Comment.Infrastructure;

public interface ICommentService : IGenericService<CommentEntity>
{
    new Task<IEnumerable<CommentViewModel>?> GetAllAsync();
    new Task<CommentViewModel> GetById(int id);
    Task<bool> AddAsync(CommentAddModel entity);
    new Task<bool> Delete(int id);
}
