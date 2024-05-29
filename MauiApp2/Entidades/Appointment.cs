using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Appointment.Globals.Enums;
using Appointment.SDK.Entities;
using Configuration.Entities;

namespace Customer.Entities;

public class Appointment : BaseEntity<int>
{
    [Required]
    public DateTime StartTime {get; set;}
    [Required]
    public DateTime EndTime {get; set;}

    [Required]
    public EnumAppointmentState State {get; set;} = EnumAppointmentState.Scheduled;
    [Required]
    public EnumPaymentState PaymentState {get; set;} = EnumPaymentState.Pending;

    [Required]
    [ForeignKey("Customer")]
    public int RowidCustomer {get; set;}
    public Customer? Customer { get; set; }

    [Required]
    [ForeignKey("Employee")]
    public int RowidEmployee {get; set;}
    public Employee? Employee { get; set; }

    public virtual ICollection<AppointmentDetail>? Services {get; set;}

    public override string ToString()
    {
        return $"({Rowid}) - Inicio: {StartTime} - Fin: {EndTime}";
    }
}