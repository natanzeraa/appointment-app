using AppointmentApplication.Data;
using AppointmentApplication.ViewModels;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/api/v1/employees", (AppDbContext context) =>
{
    var employees = context.Employees;
    return employees is not null ? Results.Ok(employees) : Results.NotFound();
}).Produces<Employee>();

app.MapPost("/api/v1/employee/new", (AppDbContext context, CreateEmployeeViewModel model) =>
{
    var employee = model.MapTo();
    if (!model.IsValid) return Results.BadRequest(model.Notifications);

    context.Employees.Add(employee);
    context.SaveChanges();
    
    return Results.Created($"/api/v1/employees/{employee.Id}", employee);
});

app.Run();
