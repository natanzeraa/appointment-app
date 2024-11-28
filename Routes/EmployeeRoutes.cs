using AppointmentApplication.Data;
using AppointmentApplication.ViewModels;

namespace AppointmentApplication.Routes;

public static class EmployeeRoutes
{
    public static WebApplication MapEmployeeRoutes(this WebApplication route)
    {
        route.MapGet("/api/v1/employees", (AppDbContext context) =>
        {
            var employees = context.Employees;
            return employees is not null ? Results.Ok(employees) : Results.NotFound();
        }).Produces<Employee>();


        route.MapPost("/api/v1/employee/new", (AppDbContext context, CreateEmployeeViewModel model) =>
        {
            var employee = model.MapTo();
            if (!model.IsValid) return Results.BadRequest(model.Notifications);

            context.Employees.Add(employee);
            context.SaveChanges();

            return Results.Created($"/api/v1/employees/{employee.Id}", employee);
        });

        return route;
    }
}