using AppointmentApplication.Models;
using Flunt.Notifications;
using Flunt.Validations;

namespace AppointmentApplication.ViewModels;

public class CreateServiceViewModel : Notifiable<Notification>
{
    public string Name { get; set; } = string.Empty!;
    public string Description { get; set; } = string.Empty!;
    public decimal Price { get; set; } = decimal.Zero;

    public Service MapTo()
    {
        AddNotifications(new Contract<Notification>()
            .Requires()
            .IsNotNull(Name, "Nome é obrigatório")
            .IsNotNull(Price, "Preço é obrigatório")
        );

        return new Service(Guid.NewGuid(), Name, Description, Price);
    }
}
