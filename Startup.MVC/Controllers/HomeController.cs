using AutoMapper;
using Startup.BL.Services.CategoryService;
using Startup.BL.Services.ClientService;
using Startup.BL.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;

namespace Technician.MVC.Controllers;

public class HomeController(ICategoryService _categoryService, IClientService _clientService, IMapper _mapper) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(new HomeVM
        {
            CategoryGetVM =  await _categoryService.GetAllAsync(),
            ClientGetVM = await _clientService.GetAllAsync(),
        });
    }
}
