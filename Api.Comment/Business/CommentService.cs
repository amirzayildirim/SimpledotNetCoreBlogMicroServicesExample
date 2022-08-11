using Api.Comment.Infrastructure;
using Api.Comment.Models.Entities;
using AutoMapper;
using Shared.Models.CommentModels;
using Shared.Repository;
using Shared.Service;

namespace Api.Comment.Business;

public class CommentService : GenericService<CommentEntity>, ICommentService
{
    private readonly ICommentRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CommentService(ICommentRepository categoryRepository, IMapper mapper) : base(categoryRepository)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public Task<bool> AddAsync(CommentAddModel entity)
    {
        throw new NotImplementedException();
    }

    Task<bool> ICommentService.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<CommentViewModel>?> ICommentService.GetAllAsync()
    {
        throw new NotImplementedException();
    }

    Task<CommentViewModel> ICommentService.GetById(int id)
    {
        throw new NotImplementedException();
    }
}
