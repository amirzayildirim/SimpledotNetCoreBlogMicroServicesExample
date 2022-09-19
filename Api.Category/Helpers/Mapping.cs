using AutoMapper;
using Shared.Models.CategoryModels;

namespace Api.Category.Helpers;

public class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<CategoryAddModel, Models.Category>();
        CreateMap<CategoryUpdateModel, Models.Category>().ForMember(destinationMember=>destinationMember.UpdatedOn,operation=>operation.MapFrom(source=>DateTime.Now)).ForMember(destinationMember=>destinationMember.CreatedOn,opt=>opt.Ignore());
        CreateMap<Models.Category,CategoryViewModel>();
    }
}
