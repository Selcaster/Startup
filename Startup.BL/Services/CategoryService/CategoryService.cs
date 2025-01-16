using AutoMapper;
using Startup.BL.ViewModels.Category;
using Startup.Core.Entities;
using Startup.Core.RepositoryInterfaces;

namespace Startup.BL.Services.CategoryService;

public class CategoryService(ICategoryRepository _repository, IMapper _mapper) : ICategoryService
{
    public async Task<Guid> CreateAsync(CategoryCreateVM vm)
    {
        Category department = _mapper.Map<Category>(vm);
        await _repository.CreateAsync(department);
        _repository.SaveChanges();
        return department.Id;
    }

    public async Task<IEnumerable<CategoryGetVM>> GetAllAsync()
    {
        return _mapper.Map<IEnumerable<CategoryGetVM>>(_repository.GetAll());
    }
}
