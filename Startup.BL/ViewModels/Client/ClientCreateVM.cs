using Microsoft.AspNetCore.Http;

namespace Startup.BL.ViewModels.Client;

public class ClientCreateVM
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public IFormFile Image { get; set; }
    public int Salary { get; set; }
}
