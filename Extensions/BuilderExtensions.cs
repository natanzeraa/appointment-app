using AppointmentApplication.Data;

namespace AppointmentApplication.Extensions;

public static class BuilderExtensions
{
    public static WebApplicationBuilder AddArchitectures(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDbContext>();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        return builder;
    }
}