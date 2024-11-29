using AppointmentApplication.Models;
using AppointmentApplication.Data;
using AppointmentApplication.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace AppointmentApplication.Routes;

public static class AppointmentRoutes
{
    public static WebApplication MapAppointmentRoutes(this WebApplication route)
    {
        route.MapGet("/api/v1/appointment", async (AppDbContext context) =>
        {
            var appointments = await context.Appointments
                .Select( e => new
                {
                    e.Id,
                    e.Start,
                    e.End,
                    Employee = new
                    {
                        Name = e.Employee!.FirstName + " " + e.Employee.LastName,
                        e.Employee.Email,
                        e.Employee.Profession
                    },
                    Service = new
                    {
                        e.Service!.Name,
                        e.Service.Description,
                        e.Service.Price
                    },
                    Costumer = new
                    {
                        e.Costumer!.Name,
                        e.Costumer.PhoneNumber
                    }
                }).ToListAsync();

            return appointments is not null ? Results.Ok(appointments) : Results.NotFound("Agendamento não encontrado");
        
        }).Produces<List<Appointment>>();

        route.MapGet("/api/v1/appointment/{id}", async (Guid id, AppDbContext context) =>
        {
            var appointment = await context.Appointments
                .Where(e => e.Id == id)
                .Select(e => new
                {
                    e.Id,
                    e.Start,
                    e.End,
                    Employee = new
                    {
                        Name = e.Employee!.FirstName + " " + e.Employee.LastName,
                        e.Employee.Email,
                        e.Employee.Profession
                    },
                    Service = new
                    {
                        e.Service!.Name,
                        e.Service.Description,
                        e.Service.Price
                    },
                    Costumer = new
                    {
                        e.Costumer!.Name,
                        e.Costumer.PhoneNumber
                    }
                })
                .FirstOrDefaultAsync();

            return appointment is not null
                ? Results.Ok(appointment)
                : Results.NotFound("Agendamento não encontrado");
        });

        route.MapPost("/api/v1/appointment/new", (AppDbContext context, CreateAppointmentViewModel model) =>
        {
            var appointment = model.MapTo();

            if (!model.IsValid) return Results.BadRequest();

            context.Add(appointment);
            context.SaveChanges();

            var service = context.Services.FirstOrDefault(s => s.Id == model.ServiceId);
            var employee = context.Employees.FirstOrDefault(e => e.Id == model.EmployeeId);
            var costumer = context.Costumers.FirstOrDefault(c => c.Id == model.CostumerId);

            return Results.Created(
                $"/api/v1/appointment/{appointment.Id}",
                 new
                 {
                     id = appointment.Id,
                     start = appointment.Start,
                     end = appointment.End,
                     service = service.Name,
                     price = service.Price,
                     employee = $"{employee.FirstName} {employee.LastName}",
                     costumer = costumer.Name
                 });
        });                                             

        route.MapPut("/api/v1/appointment/{id}", (Guid Id, AppDbContext context, CreateAppointmentViewModel model) =>
        {
            var appointmentToUpdate = context.Appointments.Find(Id);

            if (appointmentToUpdate is null)
                return Results.NotFound("Agendamento não encontrado");

            if (!model.IsValid)
                return Results.BadRequest();

            var updatedAppointment = model.MapTo();

            context.Remove(appointmentToUpdate);
            context.Add(updatedAppointment);
            context.SaveChanges();

            var service = context.Services.FirstOrDefault(s => s.Id == model.ServiceId);
            var employee = context.Employees.FirstOrDefault(e => e.Id == model.EmployeeId);
            var costumer = context.Costumers.FirstOrDefault(c => c.Id == model.CostumerId);

            return Results.Ok(
                new
                {
                    id = updatedAppointment.Id,
                    start = updatedAppointment.Start,
                    end = updatedAppointment.End,
                    service = service.Name,
                    price = service.Price,
                    employee = $"{employee.FirstName} {employee.LastName}",
                    costumer = costumer.Name
                }
            );
        });

        route.MapDelete("/api/v1/appointment/{id}", (Guid Id, AppDbContext context) =>
        {
            var appointment = context.Appointments.Find(Id);

            if (appointment is null)
                return Results.NotFound("Agendamento não encontrado");

            context.Remove(appointment);
            context.SaveChanges();

            return Results.NoContent();
        });

        return route;
    }
}