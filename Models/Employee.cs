namespace AppointmentApplication.Models;

public record Employee
(
    Guid Id, 
    string FirstName, 
    string LastName, 
    string Email, 
    string Profession
)
{
    public List<Appointment> Appointments { get; init; } = new();

};