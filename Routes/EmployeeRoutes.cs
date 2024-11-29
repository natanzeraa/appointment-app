using AppointmentApplication.Data;
using AppointmentApplication.Models;
using AppointmentApplication.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace AppointmentApplication.Routes;

public static class EmployeeRoutes
{
    public static WebApplication MapEmployeeRoutes(this WebApplication route)
    {
        route.MapGet("/api/v1/employee", async (AppDbContext context) =>
        {
            var employees = await context.Employees
                .Include(e => e.Appointments)
                .Select(e => new
                {
                    e.Id,
                    e.FirstName,
                    e.LastName,
                    e.Email,
                    e.Profession,
                    Appointments = e.Appointments.Select(a => new
                    {
                        a.Id,
                        a.Start,
                        a.End
                    })
                })
                .ToListAsync();
            return employees is not null ? Results.Ok(employees) : Results.NotFound();
        }).Produces<List<object>>();

        route.MapGet("/api/v1/employee/{id}", async (Guid Id, AppDbContext context) =>
        {
            var employee = await context.Employees
                .Include(e => e.Appointments)
                .FirstOrDefaultAsync(e => e.Id == Id);

            return employee is not null ? Results.Ok(employee) : Results.NotFound("Colaborador não existe");

        }).Produces<Employee>();

        route.MapPost("/api/v1/employee/new", (AppDbContext context, CreateEmployeeViewModel model) =>
        {
            var employee = model.MapTo();
            if (!model.IsValid) return Results.BadRequest(model.Notifications);

            context.Employees.Add(employee);
            context.SaveChanges();

            return Results.Created($"/api/v1/employee/{employee.Id}", employee);
        });

        route.MapPut("/api/v1/employee/{id}", (Guid Id, AppDbContext context, CreateEmployeeViewModel model) =>
        {
            var employeeToUpdate = context.Employees.Find(Id);
            var updatedEmployee = model.MapTo();

            if (employeeToUpdate is null)
                return Results.NotFound("Colaborador não existe");

            if (!model.IsValid)
                return Results.BadRequest(model.Notifications);

            context.Remove(employeeToUpdate);
            context.Add(updatedEmployee);
            context.SaveChanges();

            return Results.Ok(updatedEmployee);
        });
        
        route.MapDelete("/api/v1/employee/{id}", (Guid Id, AppDbContext context) =>
        {
            var employeeToUpdate = context.Employees.Find(Id);

            if (employeeToUpdate is null)
                return Results.NotFound("Colaborador não existe");

            context.Remove(employeeToUpdate);
            context.SaveChanges();

            return Results.NoContent();
        });

        return route;
    }
}