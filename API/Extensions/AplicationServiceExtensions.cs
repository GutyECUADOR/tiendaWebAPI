using System.Runtime.CompilerServices;

namespace API.Extensions
{
    public static class AplicationServiceExtensions
    {
        public static void ConfigureCORS(this IServiceCollection services) => services.AddCors(options =>
        {
            options.AddPolicy("CORSPolicy", builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            });
        });
    }
}
