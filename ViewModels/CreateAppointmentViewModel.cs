using AppointmentApplication.Models;
using Flunt.Notifications;
using Flunt.Validations;

namespace AppointmentApplication.ViewModels;

public class CreateAppointmentViewModel : Notifiable<Notification>
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public Guid EmployeeId { get; set; }
    public Guid CostumerId { get; set; }
    public Guid ServiceId{ get; set; }


    public Appointment MapTo()
    {
        AddNotifications(new Contract<Notification>()
            .Requires()
            .IsNotNull(Start, "Horário de início é obrigatório")
            .IsNotNull(End, "Horário de finalização é obrigatório")
            .IsNotNullOrEmpty(EmployeeId.ToString(), "Colaborador é obrigatório")
            .IsNotNullOrEmpty(CostumerId.ToString(), "Cliente é obrigatório")
            .IsNotNullOrEmpty(ServiceId.ToString(), "Serviço é obrigatório")
        );

        return new Appointment(Guid.NewGuid(), Start, End, EmployeeId, CostumerId, ServiceId);
    }
}