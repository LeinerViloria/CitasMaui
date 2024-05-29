namespace Appointment.Globals.Enums
{
    public enum EnumRecordStatus
    {
        Active,
        Inactive,
    }

    public enum EnumGender
    {
        NotSpecified,
        Male,
        Female
    }

    public enum EnumAppointmentState
    {
        Scheduled,
        Canceled,
        Attended,
        Expired
    }

    public enum EnumPaymentState{
        Pending,
        Paid,
        Unpaid
    }
}
