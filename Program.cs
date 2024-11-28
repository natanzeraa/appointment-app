using AppointmentApplication.Routes;
using AppointmentApplication.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.AddArchitectures();

var app = builder.Build();
app.AddApplications();
app
    .MapEmployeeRoutes()
    .MapCostumerRoutes();

app.Run();
