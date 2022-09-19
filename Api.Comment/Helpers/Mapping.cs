using Api.Comment.Models.Entities;
using AutoMapper;
using Shared.Models.CommentModels;

namespace Api.Comment.Helpers;

public class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<CommentAddModel,CommentEntity>();
        CreateMap<CommentViewModel, CommentEntity>();
    }
}