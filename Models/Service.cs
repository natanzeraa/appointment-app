namespace AppointmentApplication.Models;

public record Service
(
    Guid Id,
    string Name,
    string Description,
    decimal Price
);