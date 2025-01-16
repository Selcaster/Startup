using Startup.Core.Entities;
using Startup.Core.RepositoryInterfaces;
using Startup.DAL.Context;

namespace Startup.DAL.RepositoryImplements;

public class ClientRepository : GenericRepository<Client>, IClientRepository

{
    readonly AppDbContext _context;
    public ClientRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
}
