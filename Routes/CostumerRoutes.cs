using AppointmentApplication.Data;
using AppointmentApplication.Models;
using AppointmentApplication.ViewModels;

namespace AppointmentApplication.Routes;

public static class CostumerRoutes
{
    public static WebApplication MapCostumerRoutes(this WebApplication route)
    {
        route.MapGet("/api/v1/costumer", (AppDbContext context) =>
        {
            var costumers = context.Costumers;
            return costumers is not null ? Results.Ok(costumers) : Results.NotFound();
        }).Produces<Costumer>();

        route.MapGet("/api/v1/costumer/{id}", (Guid Id, AppDbContext context) =>
        {
            var costumer = context.Costumers.Find(Id);
            return costumer is not null ? Results.Ok(costumer) : Results.NotFound();
        });

        route.MapPost("/api/v1/costumer/new", (AppDbContext context, CreateCostumerViewModel model) =>
        {
            bool phoneNumberExists(string phoneNumber) =>
                context.Costumers.Any(x => x.PhoneNumber == phoneNumber);

            var costumer = model.MapTo(phoneNumberExists);

            if (!model.IsValid) return Results.BadRequest(model.Notifications);

            context.Costumers.Add(costumer);
            context.SaveChanges();

            return Results.Created($"api/v1/costumer/{costumer.Id}", costumer);
        });

        route.MapPut("/api/v1/costumer/{id}", (Guid Id, AppDbContext context, CreateCostumerViewModel model) =>
        {
            var costumerToUpdate = context.Costumers.Find(Id);

            if(costumerToUpdate is null)
                return Results.NotFound("Cliente não econtrado");

            if(!model.IsValid)
                return Results.BadRequest();

            bool phoneNumberExists(string phoneNumber) =>
               context.Costumers.Any(x => x.PhoneNumber == phoneNumber);

            var updatedCostumer = model.MapTo(phoneNumberExists);

            context.Remove(costumerToUpdate);
            context.Add(updatedCostumer);
            context.SaveChanges();

            return Results.Ok(updatedCostumer);
        });

        route.MapDelete("/api/v1/costumer/{id}", (Guid Id, AppDbContext context) =>
        {
            var costumerToUpdate = context.Costumers.Find(Id);

            if (costumerToUpdate is null)
                return Results.NotFound("Cliente não econtrado");

            context.Remove(costumerToUpdate);
            context.SaveChanges();

            return Results.NoContent();
        });

        return route;
    }
}