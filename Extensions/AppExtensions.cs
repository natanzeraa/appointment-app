namespace AppointmentApplication.Extensions;

public static class AppExtensions
{
    public static WebApplication AddApplications(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
        return app;
    }
}