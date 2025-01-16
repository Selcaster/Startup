using Startup.Core.Entities;
using Startup.Core.RepositoryInterfaces;
using Startup.DAL.Context;

namespace Startup.DAL.RepositoryImplements;


public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    readonly AppDbContext _context;
    public CategoryRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
}