using Microsoft.EntityFrameworkCore;
using SMS_API.Models;

namespace SMS_API.Configs;

public static class SqLiteDbContextConfig
{
    public static void AddSqLiteConfig(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MessageDbContext>(builder =>
        {
            builder.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
        });
    }
}