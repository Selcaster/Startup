namespace Startup.Core.Entities;

public class Client : AuditableEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string ImageUrl { get; set; }
    public int Salary { get; set; }
    public Guid CategoryID { get; set; }
    public Category Category { get; set; }
}