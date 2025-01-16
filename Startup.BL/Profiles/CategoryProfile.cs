using AutoMapper;
using Startup.BL.ViewModels.Category;
using Startup.Core.Entities;

namespace Startup.BL.Profiles;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category,CategoryCreateVM > ().ReverseMap();
        CreateMap<Category, CategoryGetVM >().ReverseMap();
    }
}