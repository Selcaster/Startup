using Startup.BL.ViewModels.Category;
using Startup.BL.ViewModels.Client;

namespace Startup.BL.ViewModels.Common;

public class HomeVM
{
    public IEnumerable<CategoryGetVM> CategoryGetVM { get; set; }
    public IEnumerable<ClientGetVM> ClientGetVM { get; set; }
}