namespace CSharp13Features.Models;
public class Person
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }=string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public int Age { get; set; }
    public string FullName => $"{FirstName} {LastName}";
}

