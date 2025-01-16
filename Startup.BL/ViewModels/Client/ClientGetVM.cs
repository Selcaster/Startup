using Microsoft.AspNetCore.Http;
using Startup.Core.Entities;
namespace Startup.BL.ViewModels.Client;

public class ClientGetVM
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public IFormFile Image { get; set; }
    public int Salary { get; set; }
    public string CategoryName { get; set; }
}
