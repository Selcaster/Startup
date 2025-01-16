using AutoMapper;
using Startup.BL.ViewModels.Client;
using Startup.Core.Entities;

namespace Startup.BL.Profiles;

public class ClientProfile : Profile
{
    public ClientProfile()
    {
        CreateMap<ClientCreateVM, Client>().ReverseMap();
        CreateMap<ClientGetVM, Client>()
            .ForMember(x => x.Category, y => y.MapFrom(z => z.CategoryName))
            .ReverseMap();
    }
}