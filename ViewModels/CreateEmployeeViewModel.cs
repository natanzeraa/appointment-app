using AppointmentApplication.Models;
using Flunt.Notifications;
using Flunt.Validations;

namespace AppointmentApplication.ViewModels;

public class CreateEmployeeViewModel : Notifiable<Notification>
{
    public string FirstName { get; set; } = string.Empty!;
    public string LastName { get; set; } = string.Empty!;
    public string Email { get; set; } = string.Empty!;
    public string Profession { get; set; } = string.Empty!;

    public Employee MapTo()
    {
        AddNotifications(new Contract<Notification>()
            .Requires()
            .IsNotNull(FirstName, "Primeiro nome é um campo  obrigatório")
            .IsNotNull(LastName, "Sobrenome é um campo  obrigatório")
            .IsNotNull(Email, "Email é um campo  obrigatório")
            .IsNotNull(Profession, "Profissão é um campo obrigatório"));
            
        return new Employee(Guid.NewGuid(), FirstName, LastName, Email, Profession);
    }
}
