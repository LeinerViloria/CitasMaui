using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Appointment.SDK.Entities;

namespace Customer.Entities;

public class Customer : BaseUser<int>
{
    [Required]
    public string Id { get; set; } = null!;
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public string LastName { get; set; } = null!;
    public DateOnly? BirthDate { get; set; }

    public override string ToString()
    {
        return $"({Id}) - {Name} {LastName}";
    }
}