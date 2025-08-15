using user_mcp.Services.Interfaces;
using user_mcp.Services.Service;

public static class ServicesExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IUserService, UserService>();

        return services;
    }
}
