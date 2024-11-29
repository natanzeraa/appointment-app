namespace AppointmentApplication.Models;

public record Appointment
(
    Guid Id,
    DateTime Start,
    DateTime End,
    Guid EmployeeId,
    Guid CostumerId,
    Guid ServiceId
)
{
    public Employee? Employee { get; init; }
    public Costumer? Costumer { get; init; }
    public Service? Service { get; init; }
}
