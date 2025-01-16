using AutoMapper;
using Startup.BL.ViewModels.Category;
using Startup.Core.Entities;

namespace Startup.BL.Profiles;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<CategoryCreateVM, Category>().ReverseMap();
        CreateMap<CategoryGetVM, Category>().ReverseMap();
    }
}