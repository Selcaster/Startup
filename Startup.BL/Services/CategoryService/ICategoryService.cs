using Startup.BL.ViewModels.Category;

namespace Startup.BL.Services.CategoryService;

public interface ICategoryService
{
    Task<Guid> CreateAsync(CategoryCreateVM vm);
    Task<IEnumerable<CategoryGetVM>> GetAllAsync();
}