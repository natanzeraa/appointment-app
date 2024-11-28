using AppointmentApplication.Models;
using Flunt.Notifications;
using Flunt.Validations;

namespace AppointmentApplication.ViewModels;

public class CreateCostumerViewModel : Notifiable<Notification>
{
    public string Name { get; set; } = string.Empty!;
    public string PhoneNumber { get; set; } = string.Empty!;

    public Costumer MapTo(Func<string, bool> phoneNumberExists)
    {
        AddNotifications(new Contract<Notification>()
            .Requires()
            .IsNotNull(Name, "Nome é um campo obrigatório")
            .IsNotNull(PhoneNumber, "Telefone é um campo obrigatório")
            .Matches(PhoneNumber, @"^\+55\s\(\d{2}\)\s\d{4}-\d{4}$", "Número de telefone deve seguir o formato +99 (99) 9999-9999")
        );

        if (phoneNumberExists(PhoneNumber))
            AddNotification(PhoneNumber, "Este número de telefone já está em uso");

        return new Costumer(Guid.NewGuid(), Name, PhoneNumber);
    }
}