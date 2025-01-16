using Startup.BL.ViewModels.Client;

namespace Startup.BL.Services.ClientService;

public interface IClientService
{
    Task<IEnumerable<ClientGetVM>> GetAllAsync();
    Task<Guid> CreateAsync(ClientCreateVM vm);
}
