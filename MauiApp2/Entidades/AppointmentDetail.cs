using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Appointment.SDK.Entities;
using Configuration.Entities;

namespace Customer.Entities;

public class AppointmentDetail : BaseEntity<int>
{
    [Required]
    public int RowidAppointment {get; set;}

    public Appointment? Appointment { get; set;}

    [Required]
    [ForeignKey("Service")]
    public int RowidService {get; set;}
    public Service? Service { get; set; }

    public override string ToString()
    {
        return $"({Appointment?.Rowid}) - {Service?.Name}";
    }
}