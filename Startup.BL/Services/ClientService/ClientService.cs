using AutoMapper;
using Startup.BL.ViewModels.Client;
using Startup.Core.Entities;
using Startup.Core.RepositoryInterfaces;
using Startup.BL.Services.ClientService;

namespace Startup.BL.Services.ClientService;

public class ClientService(IClientRepository _repository, IMapper _mapper) : IClientService
{
    public async Task<Guid> CreateAsync(ClientCreateVM vm)
    {
        Client doctor = _mapper.Map<Client>(vm);
        await _repository.CreateAsync(doctor);
        _repository.SaveChanges();
        return doctor.Id;
    }

    public async Task<IEnumerable<ClientGetVM>> GetAllAsync()
    {
        return _mapper.Map<IEnumerable<ClientGetVM>>(_repository.GetAll());
    }
}