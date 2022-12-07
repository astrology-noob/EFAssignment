using System.ComponentModel.DataAnnotations;

namespace EFAssignment.Data;

public class User
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public int Age { get; set; }

    public User() { }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public User(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}
