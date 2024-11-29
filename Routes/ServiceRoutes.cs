using AppointmentApplication.Models;
using AppointmentApplication.Data;
using AppointmentApplication.ViewModels;

namespace AppointmentApplication.Routes;

public static class ServiceRoutes
{
    public static WebApplication MapServiceRoutes(this WebApplication route)
    {
        route.MapGet("/api/v1/service", (AppDbContext context) =>
        {
            var services = context.Services;
            return services is not null ? Results.Ok(services) : Results.NotFound("Serviço não encontrado");
        }).Produces<Service>();

        route.MapGet("/api/v1/service/{id}", (Guid Id, AppDbContext context) =>
        {
            var service = context.Services.Find(Id);
            return service is not null ? Results.Ok(service) : Results.NotFound("Serviço não encontrado");
        }).Produces<Service>(); ;

        route.MapPost("/api/v1/service/new", (AppDbContext context, CreateServiceViewModel model) => 
        {
            var service = model.MapTo();
            if (!model.IsValid) return Results.BadRequest();

            context.Add(service);
            context.SaveChanges();

            return Results.Created($"/api/v1/service/{service.Id}", service);
        });

        route.MapPut("/api/v1/service/{id}", (Guid Id, AppDbContext context, CreateServiceViewModel model) =>
        {
            var serviceToUpdate = context.Services.Find(Id);

            if(serviceToUpdate is null) 
                return Results.NotFound("Serviço não encontrado");

            if (!model.IsValid) 
                return Results.BadRequest();

            var updatedService = model.MapTo();

            context.Remove(serviceToUpdate);
            context.Add(updatedService);
            context.SaveChanges();

            return Results.Ok(updatedService);
        });

        route.MapDelete("/api/v1/service/{id}", (Guid Id, AppDbContext context) =>
        {
            var service = context.Services.Find(Id);

            if(service is null ) 
                return Results.NotFound("Serviço não encontrado");

            context.Remove(service);
            context.SaveChanges();

            return Results.NoContent();
        });

        return route;
    }
}